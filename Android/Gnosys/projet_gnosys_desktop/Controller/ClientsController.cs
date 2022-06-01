using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using projet_gnosys.Data.Dtos;
using projet_gnosys.Data.Profiles;
using projet_gnosys.Models;
using projet_gnosys.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_gnosys.Controller
{
    class ClientsController:ControllerBase
    {
        private readonly ClientServices _service;
        private readonly IMapper _mapper;

        public ClientsController(ClientServices service)
        {
            _service = service;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ClientsProfiles>();
          
            });
            _mapper = config.CreateMapper();
        }

        //GET api/Client
        [HttpGet]
        public async Task<List<ClientsDTOIn>> GetAllClientAsync()
        {
            List<Client> listeClient = await _service.GetAllClientAsync();
            return _mapper.Map<List<ClientsDTOIn>>(listeClient);
        }

        
        //POST api/Client
        [HttpPost]
        public async Task CreateClientAsync(Client obj)
        {
            ClientsDTOOut newCli = _mapper.Map<ClientsDTOOut>(obj);
            await _service.AddClientAsync(newCli);
        }


        //POST api/Client
        [HttpPost]
        public async Task DeleteClientAsync(int id)
        {
            await _service.DeleteClientAsync(id);
        }

        //POST api/Client
        [HttpPost]
        public async Task UpdateClientAsync(Client obj, int id)
        {
            await _service.UpdateClientAsync(obj,id);
        }

    }
}
