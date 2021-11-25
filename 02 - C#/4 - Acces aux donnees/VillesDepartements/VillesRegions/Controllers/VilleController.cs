using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VillesRegions.Data.Dtos;
using VillesRegions.Data.Models;
using VillesRegions.Data.Services;

namespace VillesRegions.Controllers
{
    [Route("api/Ville")]
    [ApiController]
    public class VilleController:ControllerBase
    {
        private readonly VillesServices _service;
        private readonly IMapper _mapper;

        public VilleController(VillesServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<VilleDTO>>GetAllVilles()
        {
            IEnumerable<Ville> listeVilles = _service.GetAllVilles();
            return Ok(_mapper.Map<IEnumerable<VilleDTO>>(listeVilles));
           
        }
    }
}
