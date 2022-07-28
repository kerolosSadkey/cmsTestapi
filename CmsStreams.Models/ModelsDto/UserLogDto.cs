using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsStreams.Models.ModelsDto
{
    public class UserLogDto
    {
        public int Id { get; set; }
        public DateTime Login_date { get; set; }
        public DateTime Logout_date { get; set; }
        public string Ip_address { get; set; }

        public string userFirstName { get; set; }
        public string userLastName { get; set; }

    }
}
