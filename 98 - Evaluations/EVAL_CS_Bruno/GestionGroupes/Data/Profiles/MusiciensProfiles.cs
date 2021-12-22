using AutoMapper;
using ECF.Data.Dtos;
using ECF.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECF.Data.Profiles
{
    class MusiciensProfiles : Profile
    {
        public MusiciensProfiles()
        {
            CreateMap<Musicien, MusiciensDTOIn>();
            CreateMap<MusiciensDTOIn, Musicien>();
            CreateMap<Musicien, MusiciensDTOOut>();
            CreateMap<MusiciensDTOOut, Musicien>();
            CreateMap<MusiciensDTOOutAvecGroupe, Musicien>();
            CreateMap<Musicien, MusiciensDTOOutAvecGroupe>().ForMember(d => d.NomDuGroupe, o => o.MapFrom(s => s.GroupeListe.NomDuGroupe));
        }
    }
}
