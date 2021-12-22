using AutoMapper;
using ECF.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECF.Data.Models;

namespace ECF.Data.Profiles
{
    class GroupesProfiles:Profile
    {
        public GroupesProfiles()
        {
            CreateMap<Groupe, GroupesDTOIn>();
            CreateMap<GroupesDTOIn, Groupe>();
            CreateMap<Groupe, GroupesDTOOut>();
            CreateMap<GroupesDTOOut, Groupe>();
        }
    }
}
