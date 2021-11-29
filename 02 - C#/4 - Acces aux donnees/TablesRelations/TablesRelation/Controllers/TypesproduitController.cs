using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TablesRelation.Data.Models;
using TablesRelation.Data.Services;

namespace TablesRelation.Controllers
{
    [Route("api/Typesproduit")]
    [ApiController]
    public class TypesproduitController:ControllerBase
    {


        private readonly TypesproduitServices _service;
        private readonly IMapper _mapper;

        public TypesproduitController(TypesproduitServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Typesproduit
        [HttpGet]
        public ActionResult<IEnumerable<Typesproduit>> GetAllTypesproduit()
        {
            IEnumerable<Typesproduit> listeTypesproduit = _service.GetAllTypesProduit();
            return Ok(_mapper.Map<IEnumerable<Typesproduit>>(listeTypesproduit));
        }

        //GET api/Typesproduit/{i}
        [HttpGet("{id}", Name = "GetTupeProduitById")]
        public ActionResult<Typesproduit> GetTypeProduitById(int id)
        {
            Typesproduit commandItem = _service.GetTypeProduitById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<Typesproduit>(commandItem));
            }
            return NotFound();
        }

        //POST api/Typesproduit
        [HttpPost]
        public ActionResult<Typesproduit> CreateNomModel(Typesproduit obj)
        {
            _service.AddTypeProduit(obj);
            return CreatedAtRoute(nameof(GetTypeProduitById), new { Id = obj.IdTypeProduit }, obj);
        }

        //POST api/Typesproduit/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateNomModel(int id, Typesproduit obj)
        {
            Typesproduit objFromRepo = _service.GetTypeProduitById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateTypeProduit(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Typesproduit/{id}
        /*[HttpPatch("{id}")]
        public ActionResult PartialNomModelUpdate(int id, JsonPatchDocument<NomModel> patchDoc)
        {
            NomModel objFromRepo = _service.GetNomModelById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            NomModel objToPatch = _mapper.Map<NomModel>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateNomModel(objFromRepo);
            return NoContent();
        }*/

        //DELETE api/Typesproduit/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteNomModel(int id)
        {
            Typesproduit obj = _service.GetTypeProduitById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteTypeProduit(obj);
            return NoContent();
        }




    }
}
