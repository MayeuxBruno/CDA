using AnimauxMulticouche.Data.Dto;
using AnimauxMulticouche.Data.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimauxMulticouche.Data.Profiles
{
    public class AnimalProfiles:Profile
    {
        public AnimalProfiles()
        {
            CreateMap<Animal, AnimalDTO>();
            CreateMap<AnimalDTO, Animal>();
            CreateMap<Animal, AnimalAvecLibDTO>();
            CreateMap<AnimalAvecLibDTO, Animal>();
        }
    }
}
