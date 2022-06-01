using AutoMapper;
using projet_gnosys.Data.Dtos;
using projet_gnosys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_gnosys.Data.Profiles
{
    class ClientsProfiles:Profile
    {
        public ClientsProfiles()
        {
            CreateMap<Client, ClientsDTOIn>();
            CreateMap<ClientsDTOIn, Client>();

            CreateMap<Client, ClientsDTOOut>();
            CreateMap<ClientsDTOOut, Client>();

            CreateMap<ClientsDTOOut, ClientsDTOIn>();
            CreateMap<ClientsDTOIn, ClientsDTOOut>();
          
        }
    }
}
