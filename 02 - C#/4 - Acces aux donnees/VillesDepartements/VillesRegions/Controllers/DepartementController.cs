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
    [Route("api/Departement")]
    [ApiController]
    public class DepartementController : ControllerBase
    {
        private readonly DepartementsServices _service;
        private readonly IMapper _mapper;

        public DepartementController(DepartementsServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<DepartementDTO>> GetAllDepartements()
            {
            IEnumerable<Departement> listeDepartement = _service.GetAllDepartements();
            return Ok(_mapper.Map<IEnumerable<DepartementDTO>>(listeDepartement));
            }
    }
}
