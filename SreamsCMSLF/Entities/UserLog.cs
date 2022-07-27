using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SreamsCMSLF.Entities
{
    public class UserLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime Login_date { get; set; }
        public DateTime Logout_date { get; set; }
        public string Ip_address { get; set; }


        #region
        public virtual User User { get; set; }

        [ForeignKey("User")]
        public int user_id { get; set; }
        #endregion
    }
}