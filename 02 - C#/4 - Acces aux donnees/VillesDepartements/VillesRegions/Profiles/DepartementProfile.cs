using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VillesRegions.Data.Dtos;
using VillesRegions.Data.Models;

namespace VillesRegions.Profiles
{
    public class DepartementProfile:Profile
    {
        public DepartementProfile()
        {
            CreateMap<DepartementDTO, Departement>();
            CreateMap<Departement, DepartementDTO>();
            CreateMap<DepartementDTOOut, Departement>();
            CreateMap<Departement, DepartementDTOOut>();
        }
    }
}
