using SreamsCMSLF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SreamsCMSLF.Data
{
    public class CmsDbContext :DbContext
    {
        public CmsDbContext() : base("ConnectionstringCmsDb")
        {


        }

        // Create dbsets 
        public DbSet<User> Users { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Confidentiality> Confidentialities { get; set; }
        public DbSet<DocumentAttachments> DocumentAttachments { get; set; }
        public DbSet<DocumentStatus> DocumentStatuses { get; set; }
        public DbSet<DocumentTraking> DocumentTrakings { get; set; }
        public DbSet<GroupPrivilge> GroupPrivilges { get; set; }
        public DbSet<Privilege> Privileges { get; set; }
        public DbSet<UserLog> UserLogs { get; set; }
    }
}