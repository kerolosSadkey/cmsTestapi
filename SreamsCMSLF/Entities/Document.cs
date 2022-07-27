using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SreamsCMSLF.Entities
{
    public class Document
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int laserfiche_id { get; set; }
        public string laserfiche_path { get; set; }
        public string subject { get; set; }
        public DateTime Document_date { get; set; }
        public string Entry_name { get; set; }
        public string Email { get; set; }

        public DateTime Due_date { get; set; }
        public int Assignee_to { get; set; }
        public int Assignee_to_group { get; set; }
        public string Comment { get; set; }




        #region FOR Relations between entities with document


        public virtual Collection<DocumentAttachments> DocumentAttachments { get; set; } // relation one to many with Document_Attachments
        public virtual Priorities priorities { get; set; } // relation one to many with priorities 

        [ForeignKey("priorities")]
        public int priority_id { get; set; }


        public virtual Group Group { get; set; } // relation one to many with Groups


        [ForeignKey("Group")]
        public int assignee_group_id { get; set; }

        public virtual DocumentStatus DocumentStatus { get; set; } // relation one to many with Document_Status


        [ForeignKey("DocumentStatus")]
        public int document_status_id { get; set; }

        public virtual User User { get; set; } // relation one to many with users


        [ForeignKey("User")]

        public int user_added_id { get; set; }

        public virtual Confidentiality confidentiality { get; set; } // relation one to many with confidentiality


        [ForeignKey("confidentiality")]

        public int confidentiality_id { get; set; }

        #endregion
    }
}