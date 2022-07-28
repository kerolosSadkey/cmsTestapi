using AutoMapper;
using CmsStreams.Models.ModelsDto;
using SreamsCMSLF.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SreamsCMSLF.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DocumentAttachments, DocumentAttachmentsDto>();
            CreateMap<Document, DocumentDto>();
            CreateMap<DocumentStatus, DocumentStatusDto>();
            CreateMap<DocumentTraking, DocumentTrakingDto>();
            CreateMap<Group, GroupDto>();
            CreateMap<GroupPrivilge, GroupPrivilgeDto>();
            CreateMap<Organization, OrganizationDto>();
            CreateMap<Privilege, PrivilegeDto>();
            CreateMap<UserLog, UserLogDto>();


            //-----------------------------------------
            CreateMap<DocumentAttachmentsDto, DocumentAttachments>();
            CreateMap<DocumentDto, Document>();
            CreateMap<DocumentStatusDto, DocumentStatus>();
            CreateMap<DocumentTrakingDto, DocumentTraking>();
            CreateMap< GroupDto, Group>();
            CreateMap<GroupPrivilgeDto, GroupPrivilge>();
            CreateMap<OrganizationDto, Organization>();
            CreateMap<PrivilegeDto, Privilege>();
            CreateMap<UserLogDto, UserLog>();

        }
    }
}
