using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SreamsCMSLF.Entities
{
    public class Organization
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        public string email { get; set; }
        public string Description { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string phone { get; set; }

        public string fax { get; set; }

        public string landline { get; set; }

        public string logo { get; set; }

        [ForeignKey("organization")]
        public int? PerantId { get; set; }

        public Organization organization { get; set; }
    }
}