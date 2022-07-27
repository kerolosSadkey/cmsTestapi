using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamsCms.Models.Dtos
{
    public  class DocumentDto
    {
        public int Id { get; set; }
        public int laserfiche_id { get; set; }
        public string laserfiche_path { get; set; }
        public string subject { get; set; }
        public DateTime Document_date { get; set; }
        public string Entry_name { get; set; }
        public string Email { get; set; }

        public DateTime Due_date { get; set; }
        public int Assignee_to { get; set; }
        public int Assignee_to_group { get; set; }
        public string Comment { get; set; }
        public string PriortyName { get; set; }
        public string GroupName { get; set; }
        public string Documentstatus { get; set; }
        public UserDto user { get; set; }
        public string confidentialityName { get; set; }

    }
}
