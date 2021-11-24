using AutoMapper;
using Garage.Data.Dtos;
using Garage.Data.Models;
using Garage.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Garage.Data.Models.DbModels;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.JsonPatch;


namespace Garage.Data.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController:ControllerBase
    {
        private readonly ClientsServices _service;
        private readonly IMapper _mapper;

        public ClientsController(ClientsServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ClientsDTO>> GetAllClients()
        {
            IEnumerable<Client> listeClients = _service.GetAllClients();
            return Ok(_mapper.Map<IEnumerable<ClientsDTO>>(listeClients));
        }
    }
}
