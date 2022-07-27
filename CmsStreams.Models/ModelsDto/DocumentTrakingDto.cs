using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsStreams.Models.ModelsDto
{
    public class DocumentTrakingDto
    {
        public int Id { get; set; }

        public int Change_by { get; set; }
        public DateTime Change_date { get; set; }
        public string Change { get; set; }
        public string Comment { get; set; }

       public string confidentialityName { get; set; }

        public string Documentsubject { get; set; }
        public string DocumentDueDate { get; set; }
    }
}
