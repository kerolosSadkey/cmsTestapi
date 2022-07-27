using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SreamsCMSLF.Entities
{
    public class DocumentStatus
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Status_name { get; set; }

        #region
        public virtual Collection<Document> Documents { get; set; }
        #endregion
    }
}