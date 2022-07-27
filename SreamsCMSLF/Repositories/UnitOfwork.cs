using SreamsCMSLF.Data;
using SreamsCMSLF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SreamsCMSLF.Repositories
{
    public class UnitOfwork : IUnitOfwork
    {
        private readonly CmsDbContext Context;
        public IGenericRepository<Confidentiality> Confidentiality { get; set; }
        public IGenericRepository<Document> Document { get; set; }
        public IGenericRepository<DocumentAttachments> DocumentAttachment { get; set; }
        public IGenericRepository<DocumentStatus> DocumentStatus { get; set; }
        public IGenericRepository<DocumentTraking> DocumentTraking { get; set; }

        public IGenericRepository<Group> Group { get; set; }

        public IGenericRepository<GroupPrivilge> GroupPrivilge { get; set; }

        public IGenericRepository<Organization> Organization { get; set; }

        public IGenericRepository<Priorities> Priorities { get; set; }

        public IGenericRepository<Privilege> Privilege { get; set; }

        public IGenericRepository<User> User { get; set; }
   
        public IGenericRepository<UserLog> UserLog { get; set; }

        public UnitOfwork(CmsDbContext _Context)
        {
            Context = _Context;
            Confidentiality = new GenericRepository<Confidentiality>(Context);
            Document = new GenericRepository<Document>(Context);
            DocumentAttachment = new GenericRepository<DocumentAttachments>(Context);
            DocumentStatus = new GenericRepository<DocumentStatus>(Context);
            DocumentTraking = new GenericRepository<DocumentTraking>(Context);
            Group = new GenericRepository<Group>(Context);
            GroupPrivilge = new GenericRepository<GroupPrivilge>(Context);
            Organization = new GenericRepository<Organization>(Context);
            Priorities = new GenericRepository<Priorities>(Context);
            Privilege = new GenericRepository<Privilege>(Context);
            User = new GenericRepository<User>(Context);
         
            UserLog = new GenericRepository<UserLog>(Context);
        }
        public void Save()
        {
            Context.SaveChanges();
        }
    }
}