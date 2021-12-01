using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestEF.Data.Dtos;
using TestEF.Data.Models;
using TestEF.Data.Services;

namespace TestEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonnesController:ControllerBase
    {
        private readonly PersonnesServices _service;
        private readonly IMapper _mapper;

        public PersonnesController(PersonnesServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PersonnesDTO>> getAllPersonnes()
        {
            var listePersonnes = _service.GetAllPersonnes();
            return Ok(_mapper.Map<IEnumerable<PersonnesDTO>>(listePersonnes));
        }

        [HttpGet("{id}",Name ="GetPersonneById")]
        public ActionResult<PersonnesDTO> GetPersonneById(int id)
        {
            var commandItem = _service.GetPersonneById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<PersonnesDTO>(commandItem));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<PersonnesDTO> CreatePersonne(Personne personne)
        {
            //on ajoute l'objet à la base de données
            _service.AddPersonne(personne);
            //on retourne le chemin de findById avec l'objet créé
            return CreatedAtRoute(nameof(GetPersonneById), new { Id = personne.IdPersonne }, personne);
        }

        [HttpPut("{id}")]
        public ActionResult UpdatePersonne(int id,PersonnesDTO personne)
        {
            var personneFromRepro = _service.GetPersonneById(id);
            if (personneFromRepro == null)
            {
                return NotFound();
            }
            _mapper.Map(personne, personneFromRepro);
            _service.UpdatePersonne(personneFromRepro);
            return NoContent();
        }

        [HttpPatch("{id}")]
        public ActionResult PartialPersonneUpdate (int id, JsonPatchDocument<Personne>patchDoc)
        {
            var personneFromRepro = _service.GetPersonneById(id);
            if(personneFromRepro == null)
            {
                return NotFound();
            }
            var personneToPatch = _mapper.Map<Personne>(personneFromRepro);
            patchDoc.ApplyTo(personneToPatch, ModelState);
            if (!TryValidateModel(personneToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(personneToPatch, personneFromRepro);
            _service.UpdatePersonne(personneFromRepro);
            return NoContent();
        }
    }
}
