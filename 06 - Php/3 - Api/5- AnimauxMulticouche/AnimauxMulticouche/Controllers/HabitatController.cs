using AnimauxMulticouche.Data.Dto;
using AnimauxMulticouche.Data.Models;
using AnimauxMulticouche.Data.Services;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimauxMulticouche.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class HabitatController:ControllerBase
    {

        private readonly HabitatServices _service;
        private readonly IMapper _mapper;

        public HabitatController(HabitatServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Habitat
        [EnableCors("toto")]
        [HttpGet]
        public ActionResult<IEnumerable<HabitatDTO>> GetAllHabitats()
        {
            IEnumerable<Habitat> listeHabitat = _service.GetAllHabitats();
            return Ok(_mapper.Map<IEnumerable<HabitatDTO>>(listeHabitat));
        }

        //GET api/Habitat/{i}
        [EnableCors("toto")]
        [HttpGet("{id}", Name = "GetHabitatById")]
        public ActionResult<HabitatDTO> GetHabitatById(int id)
        {
            Habitat commandItem = _service.GetHabitatById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<HabitatDTO>(commandItem));
            }
            return NotFound();
        }

        //POST api/Habitat
        [EnableCors("toto")]
        [HttpPost]
        public ActionResult<HabitatDTO> CreateHabitat(Habitat obj)
        {
            _service.AddHabitat(obj);
            return CreatedAtRoute(nameof(GetHabitatById), new { Id = obj.IdHabitat }, obj);
        }

        //POST api/Habitat/{id}
        [EnableCors("toto")]
        [HttpPut("{id}")]
        public ActionResult UpdateHabitat(int id, HabitatDTO obj)
        {
            Habitat objFromRepo = _service.GetHabitatById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateHabitat(objFromRepo);
            return NoContent();
        }

        //DELETE api/Habitat/{id}
        [EnableCors("toto")]
        [HttpDelete("{id}")]
        public ActionResult DeleteNomModel(int id)
        {
            Habitat obj = _service.GetHabitatById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteHabitat(obj);
            return NoContent();
        }


    }
}
