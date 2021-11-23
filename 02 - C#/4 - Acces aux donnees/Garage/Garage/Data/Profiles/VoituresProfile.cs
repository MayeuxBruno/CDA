using AutoMapper;
using Garage.Data.Dtos;
using Garage.Data.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garage.Data.Profiles
{
    public class VoituresProfile:Profile
    {
        public VoituresProfile()
        {
            CreateMap<Voiture, VoituresDTO>();
            CreateMap<VoituresDTO, Voiture>();
        }
    }
}
