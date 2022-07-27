using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SreamsCMSLF.Entities
{
    public class DocumentAttachments
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string File_name { get; set; }
        public string File_type { get; set; }
        public decimal File_size { get; set; }


        public virtual Document documents { get; set; }

        [ForeignKey("documents")]
        public int document_id { get; set; }

    }
}