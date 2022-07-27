using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SreamsCMSLF.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Middle_name { get; set; }
        public string Last_name { get; set; }
        public string Phone_number { get; set; }
        public string Address { get; set; }
        public DateTime Date_birth { get; set; }
        public DateTime Created_at { get; set; }
        public string Title { get; set; }

        public string User_name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool Is_laserfiche_user { get; set; }


        #region for Relations between entities with User

        public virtual Collection<Document> Documents { get; set; }
        public virtual Collection<UserLog> Users_Logs { get; set; }


        public virtual Group Group { get; set; }
        [ForeignKey("Group")]
        public int Group_id { get; set; }


        public virtual Organization Organization { get; set; }

        [ForeignKey("Organization")]
        public int Organization_id { get; set; }
        #endregion
    }
}