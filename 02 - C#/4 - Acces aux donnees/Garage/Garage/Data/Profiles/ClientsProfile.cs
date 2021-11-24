using AutoMapper;
using Garage.Data.Dtos;
using Garage.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garage.Data.Profiles
{
    public class ClientsProfile:Profile
    {
        public ClientsProfile()
        {
            CreateMap<Client, ClientsDTO>();
            CreateMap<ClientsDTO, Client>();
        }
        
        
    }
}
