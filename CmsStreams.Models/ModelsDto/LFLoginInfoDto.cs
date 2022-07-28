using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsStreams.Models.ModelsDto
{
  public class LFLoginInfoDto
    {
        public string ServerName { get; set; }
        public string RepositoryName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
