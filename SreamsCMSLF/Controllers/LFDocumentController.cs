using Laserfiche.RepositoryAccess;
using Laserfiche.DocumentServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CmsStreams.Models.ModelsDto;
using System.Web;

namespace SreamsCMSLF.Controllers
{
    [RoutePrefix("api/LFDocument")]
    public class LFDocumentController : ApiController
    {

       
        public LFDocumentController() { }



        [HttpPost]
        [Route("Importdocument")]
        public IHttpActionResult ImportDocument()
        {
            try
            {
                LFLoginInfoDto lfLoginInfoDto = new LFLoginInfoDto()
                {
                     ServerName= "172.16.0.10",
                      RepositoryName= "Streams",
                      UserName= "admin",
                      Password= "admin"
                };

          
                    var httpRequest = HttpContext.Current.Request;
                // "using" block ensures the session is logged out automatically
                using (Session session = LogIn(lfLoginInfoDto))
                {

                    // "using" block ensures the document is unlocked when we are done with it
                    using (DocumentInfo newDoc = new DocumentInfo(session))
                    {
                        FolderInfo parentFolder = GetOrCreateFolder(session);
                        newDoc.Create(parentFolder, "Streams", EntryNameOption.AutoRename);
                        DocumentImporter docImporter = new DocumentImporter();
                        // Assign the document object
                        docImporter.Document = newDoc;
                        //docImporter.ImportText("txt.txt");
                        foreach (string fileName in httpRequest.Files.Keys)
                        {
                            var file = httpRequest.Files[fileName];
                            var filePath = HttpContext.Current.Server.MapPath("~/" + file.FileName);
                            file.SaveAs(filePath);
                            string mimeType = GetMimeType(file.FileName);
                            // Extract text from the electronic file
                            docImporter.ExtractTextFromEdoc = false;
                            // Perform the import
                            docImporter.ImportEdoc(mimeType, filePath);
                            int docIOd = docImporter.Document.Id;
                        }
                       
                    }

                    return Ok();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        Session LogIn(LFLoginInfoDto lfLoginInfoDto)
        {
                    string serverName = lfLoginInfoDto.ServerName.Trim();
                    string repositoryName = lfLoginInfoDto.RepositoryName.Trim();
                    string username = lfLoginInfoDto.UserName.Trim();
                    string password = lfLoginInfoDto.Password.Trim();

                    Session session = new Session();
                    RepositoryRegistration rr = new RepositoryRegistration(serverName, repositoryName);

                    if (!string.IsNullOrEmpty(username))
                    {
                        session.LogIn(username, password, rr);

                    }
                    else
                        session.LogIn(rr);
            return session;

        }
        

            FolderInfo GetOrCreateFolder(Session session)
            {
                FolderInfo destFolder = (FolderInfo)Entry.TryGetEntryInfo(EntryPath.Make(@"\", "lfFolder"), session);
                if (destFolder == null)
                {
                    destFolder = new FolderInfo(session);
                    destFolder.Create(EntryPath.Make(@"\", "lfFolder"), "", EntryNameOption.None);
                }

                return destFolder;
            }
        private string GetMimeType(string fileName)
        {
            string mimeType = "application/unknown";
            string ext = System.IO.Path.GetExtension(fileName).ToLower();
            Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(ext);
            if (regKey != null && regKey.GetValue("Content Type") != null)
                mimeType = regKey.GetValue("Content Type").ToString();
            return mimeType;
        }
    }
}
