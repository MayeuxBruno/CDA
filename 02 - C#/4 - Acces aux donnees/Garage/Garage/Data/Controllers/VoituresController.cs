using AutoMapper;
using Garage.Data.Dtos;
using Garage.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Garage.Data.Models.DbModels;

namespace Garage.Data.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoituresController:ControllerBase
    {
        private readonly VoituresServices _service;
        private readonly IMapper _mapper;

        public VoituresController(VoituresServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<VoituresDTO>> GetAllVoitures()
        {
            var listeVoitures = _service.GetAllVoitures();
            return Ok(_mapper.Map<IEnumerable<VoituresDTO>>(listeVoitures));
        }

        [HttpGet("{id}",Name ="GetVoitureById")]
        public ActionResult<VoituresDTO> GetVoitureByID(int id)
        {
            var commandItem = _service.GetVoitureById(id);
            if (commandItem!=null)
            {
                return Ok(_mapper.Map<VoituresDTO>(commandItem));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<VoituresDTO> CreateVoiture(Voiture voiture)
        {
            _service.AddVoiture(voiture);
            return CreatedAtRoute(nameof(GetVoitureByID),new { id = voiture.IdVoiture },voiture);
        }
    }

    

}
