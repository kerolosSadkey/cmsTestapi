using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsStreams.Models.ModelsDto
{
    public class PrivilegeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Parent_id { get; set; }
        public DateTime created_at { get; set; }
    }
}
