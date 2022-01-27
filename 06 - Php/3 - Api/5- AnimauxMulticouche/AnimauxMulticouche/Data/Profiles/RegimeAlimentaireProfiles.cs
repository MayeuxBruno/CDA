using AnimauxMulticouche.Data.Dto;
using AnimauxMulticouche.Data.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimauxMulticouche.Data.Profiles
{
    public class RegimeAlimentaireProfiles:Profile
    {
        public RegimeAlimentaireProfiles()
        {
            CreateMap<Regimesalimentaire, RegimeAlimentaireDTO>();
            CreateMap<RegimeAlimentaireDTO, Regimesalimentaire>();
        }
    }
}
