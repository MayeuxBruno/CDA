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

        [HttpDelete("{id}")]
        public ActionResult DeleteVoiture(int id)
        {
            var voitureModelFromRepro = _service.GetVoitureById(id);
            if (voitureModelFromRepro==null)
            {
                return NotFound();
            }
            _service.DeleteVoiture(voitureModelFromRepro);
            return NoContent();
        }

        [HttpPut ("{id}")]
        public ActionResult ModifVoiture(int id,VoituresDTO voiture)
        {
            var voitureFromRepro = _service.GetVoitureById(id);
            if (voitureFromRepro==null)
            {
                return NotFound();
            }
            _mapper.Map(voiture,voitureFromRepro);
            _service.UpdateVoiture(voitureFromRepro);
            return NoContent();
        }

        [HttpPatch("{id}")]
        public ActionResult ModifPartielVoiture(int id,JsonPatchDocument<Voiture> patchDoc)
        {
            var voitureFromRepro=_service.GetVoitureById(id);
            if (voitureFromRepro==null)
            {
                return NotFound();
            }
            var voitureToPatch = _mapper.Map<Voiture>(voitureFromRepro);
            patchDoc.ApplyTo(voitureToPatch, ModelState);
            if (!TryValidateModel(voitureToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(voitureToPatch, voitureFromRepro);
            _service.UpdateVoiture(voitureFromRepro);
            return NoContent();
        }
    }

    

}
