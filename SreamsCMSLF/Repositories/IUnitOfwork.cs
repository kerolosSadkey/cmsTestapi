using SreamsCMSLF.Entities;
using SreamsCMSLF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  SreamsCMSLF.Repositories
{
    public interface IUnitOfwork
    {
        IGenericRepository<Confidentiality> Confidentiality { get; set; }
        IGenericRepository<Document> Document { get; set; }
        IGenericRepository<DocumentAttachments> DocumentAttachment { get; set; }
        IGenericRepository<DocumentStatus> DocumentStatus { get; set; }
        IGenericRepository<DocumentTraking> DocumentTraking { get; set; }

        IGenericRepository<Group> Group { get; set; }

        IGenericRepository<GroupPrivilge> GroupPrivilge { get; set; }

        IGenericRepository<Organization> Organization { get; set; }

        IGenericRepository<Priorities> Priorities { get; set; }

        IGenericRepository<Privilege> Privilege { get; set; }

        IGenericRepository<User> User { get; set; }
     
        IGenericRepository<UserLog> UserLog { get; set; }

         void Save();
    }
}
