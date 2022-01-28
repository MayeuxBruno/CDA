using AnimauxMulticouche.Data.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimauxMulticouche.Data.Dto;
using AnimauxMulticouche.Data.Models;

namespace AnimauxMulticouche.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class AnimalController:ControllerBase
    {
        private readonly AnimalServices _service;
        private readonly IMapper _mapper;

        public AnimalController(AnimalServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Animal
        [EnableCors("toto")]
        [HttpGet]
        public ActionResult<IEnumerable<AnimalDTO>> GetAllAnimal()
        {
            IEnumerable<Animal> listeAnimal = _service.GetAllAnimaux();
            return Ok(_mapper.Map<IEnumerable<AnimalDTO>>(listeAnimal));
        }

        //GET api/Animal/{i}
        [EnableCors("toto")]
        [HttpGet("{id}", Name = "GetAnimalById")]
        public ActionResult<AnimalDTO> GetAnimalById(int id)
        {
            Animal commandItem = _service.GetAnimalById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<AnimalDTO>(commandItem));
            }
            return NotFound();
        }

        //POST api/Animal
        [EnableCors("toto")]
        [HttpPost]
        public ActionResult<AnimalDTO> CreateAnimal(AnimalDTO obj)
        {
            _service.AddAnimal(_mapper.Map<Animal>(obj));
            return CreatedAtRoute(nameof(GetAnimalById), new { Id = obj.IdAnimal }, obj);
        }

        //POST api/Animal/{id}
        [EnableCors("toto")]
        [HttpPut("{id}")]
        public ActionResult UpdateAnimal(int id, AnimalDTO obj)
        {
            Animal objFromRepo = _service.GetAnimalById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateAnimal(objFromRepo);
            return NoContent();
        }

        //DELETE api/Animal/{id}
        [EnableCors("toto")]
        [HttpDelete("{id}")]
        public ActionResult DeleteAnimal(int id)
        {
            Animal obj = _service.GetAnimalById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteAnimal(obj);
            return NoContent();
        }


    }
}
