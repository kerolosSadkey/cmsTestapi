using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsStreams.Models.ModelsDto
{
    public class OrganizationDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string email { get; set; }
        public string Description { get; set; }

       
        public string Address { get; set; }

      
        public string phone { get; set; }

        public string fax { get; set; }

        public string landline { get; set; }

        public string logo { get; set; }

   
        public int? PerantId { get; set; }

       
    }
}
