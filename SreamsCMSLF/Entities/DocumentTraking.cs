using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SreamsCMSLF.Entities
{
    public class DocumentTraking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int Change_by { get; set; }
        public DateTime Change_date { get; set; }
        public string Change { get; set; }
        public string Comment { get; set; }


        #region relation
        public virtual Document Documents { get; set; }
        [ForeignKey("Documents")]
        public int document_id { get; set; }

        public virtual Confidentiality confidentiality { get; set; } // relation one to many with confidentiality


        [ForeignKey("confidentiality")]

        public int confidentiality_id { get; set; }

        #endregion
    }
}