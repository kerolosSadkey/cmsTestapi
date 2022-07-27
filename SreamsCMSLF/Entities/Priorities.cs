using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace SreamsCMSLF.Entities
{
    public class Priorities
    {
        public int Id { get; set; }
        public string PriorityName { get; set; }


        #region For Relation between entities

        public virtual Collection<Document> Document { get; set; }
        public virtual Collection<DocumentTraking> DocumentTraking { get; set; }
        #endregion
    }
}