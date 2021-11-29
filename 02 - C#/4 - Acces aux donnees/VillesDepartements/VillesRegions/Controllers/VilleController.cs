using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VillesRegions.Data.Dtos;
using VillesRegions.Data.Models;
using VillesRegions.Data.Services;
using VillesRegions.Helpers;

namespace VillesRegions.Controllers
{
    [Route("api/Ville")]
    [ApiController]
    public class VilleController : ControllerBase
    {
        private readonly VillesServices _service;
        private readonly IMapper _mapper;

        public VilleController(VillesServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<VilleDTO>> GetAllVilles()
        {
            IEnumerable<Ville> listeVilles = _service.GetAllVilles();
            return Ok(_mapper.Map<IEnumerable<VilleDTO>>(listeVilles));

        }

        [HttpGet("{id}", Name = "GetVilleById")]
        public ActionResult<VilleDTO> GetVilleById(int id)
        {
            Ville v = _service.GetVilleById(id);
            return Ok(_mapper.Map<VilleDTO>(v));
        }

        [HttpPost]
        public ActionResult CreateVille(VilleDTOIn ville)
        {
            _service.AddVille(ville);
            return NoContent();
        }

        [HttpPut("{id}")]
        public ActionResult UpdateVille(int id ,VilleDTO ville)
        {
            var villeFromRepro = _service.GetVilleById(id);
            if (villeFromRepro==null)
            {
                return NotFound();
            }
            _mapper.Map(ville,villeFromRepro);
            _service.UpdateVille(villeFromRepro);
            return NoContent();
        }
    }
}
