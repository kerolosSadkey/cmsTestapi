using StreamsCms.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsStreams.Models.ModelsDto
{
    public class GroupDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created_at { get; set; }

        public  ICollection<DocumentDto> Document { get; set; }

        public  ICollection<UserDto> User { get; set; }


        public  ICollection<GroupPrivilgeDto> GroupPrivilg { get; set; }

    }
}
