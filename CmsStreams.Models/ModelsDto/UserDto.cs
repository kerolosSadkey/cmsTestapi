using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsStreams.Models.ModelsDto
{
    public  class UserDto
    {
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Middle_name { get; set; }
        public string Last_name { get; set; }
        public string Phone_number { get; set; }
        public string Address { get; set; }
        public DateTime? Date_birth { get; set; }
        public DateTime Created_at { get; set; }
        public string Title { get; set; }
        public string  Group_Name { get; set; }
        public string  Organization{ get; set; }
        public string User_name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool Is_laserfiche_user { get; set; }

    }
}
