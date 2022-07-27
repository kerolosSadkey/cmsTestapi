using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace SreamsCMSLF.Entities
{
    public class Privilege
    {


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Parent_id { get; set; }
        public DateTime created_at { get; set; }
    }
}