using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsStreams.Models.ModelsDto
{
   public class DocumentAttachmentsDto
    {
        public int Id { get; set; }
        public string File_name { get; set; }
        public string File_type { get; set; }
        public decimal File_size { get; set; }

        public DateTime DocumentDuedate { get; set; }   

        public string DoucumentSubject { get; set; }
    }
}
