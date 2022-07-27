using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SreamsCMSLF.Entities
{
    public class Group
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created_at { get; set; }


        #region
        public virtual Collection<Document> Document { get; set; }

        public virtual Collection<User> User { get; set; }


        public virtual Collection<GroupPrivilge> GroupPrivilg { get; set; }

        #endregion
    }
}