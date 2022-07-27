using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SreamsCMSLF.Entities
{
    public class GroupPrivilge
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }



        #region relations
        public virtual Privilege Privileges { get; set; }

        [ForeignKey("Privileges")]
        public int Privilege_id { get; set; }


        public virtual Group Groups { get; set; }

        [ForeignKey("Groups")]
        public int group_id { get; set; }
        #endregion

    }
}