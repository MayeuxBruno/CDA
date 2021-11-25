using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VillesRegions.Data.Dtos;
using VillesRegions.Data.Models;

namespace VillesRegions.Profiles
{
    public class VilleProfile:Profile
    {
        public VilleProfile()
        {
            CreateMap<VilleDTO, Ville>();
            CreateMap<Ville, VilleDTO>();
        }
    }
}
