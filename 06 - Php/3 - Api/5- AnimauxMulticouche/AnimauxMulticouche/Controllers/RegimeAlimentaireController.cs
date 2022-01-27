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
    public class RegimeAlimentaireController:ControllerBase
    {

        private readonly RegimeAlimentaireServices _service;
        private readonly IMapper _mapper;

        public RegimeAlimentaireController(RegimeAlimentaireServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/RegimeAlimentaire
        [EnableCors("toto")]
        [HttpGet]
        public ActionResult<IEnumerable<RegimeAlimentaireDTO>> GetAllRegimeAlimentaire()
        {
            IEnumerable<Regimesalimentaire> listeRegimeAlimentaire = _service.GetAllRegimesAlimentaires();
            return Ok(_mapper.Map<IEnumerable<RegimeAlimentaireDTO>>(listeRegimeAlimentaire));
        }

        //GET api/RegimeAlimentaire/{i}
        [EnableCors("toto")]
        [HttpGet("{id}", Name = "GetRegimeAlimentaireById")]
        public ActionResult<RegimeAlimentaireDTO> GetRegimeAlimentaireById(int id)
        {
            Regimesalimentaire commandItem = _service.GetRegimeAlimentaireById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<RegimeAlimentaireDTO>(commandItem));
            }
            return NotFound();
        }

        //POST api/RegimeAlimentaire
        [EnableCors("toto")]
        [HttpPost]
        public ActionResult<RegimeAlimentaireDTO> CreateRegimeAlimentaire(Regimesalimentaire obj)
        {
            _service.AddRegimeAlimentaire(obj);
            return CreatedAtRoute(nameof(GetRegimeAlimentaireById), new { Id = obj.IdRegimeAlimentaire }, obj);
        }

        //POST api/RegimeAlimentaire/{id}
        [EnableCors("toto")]
        [HttpPut("{id}")]
        public ActionResult UpdateRegimeAlimentaire(int id, RegimeAlimentaireDTO obj)
        {
            Regimesalimentaire objFromRepo = _service.GetRegimeAlimentaireById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateRegimeAlimentaire(objFromRepo);
            return NoContent();
        }

        //DELETE api/RegimeAlimentaire/{id}
        [EnableCors("toto")]
        [HttpDelete("{id}")]
        public ActionResult DeleteRegimeAlimentaire(int id)
        {
            Regimesalimentaire obj = _service.GetRegimeAlimentaireById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteRegimeAlimentaire(obj);
            return NoContent();
        }


    }
}
