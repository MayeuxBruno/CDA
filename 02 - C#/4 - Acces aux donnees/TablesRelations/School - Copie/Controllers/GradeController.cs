using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using School.Data.Dtos;
using School.Data.Models;
using School.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static School.Data.Dtos.DtoOut;

namespace School.Controllers
{
    public class GradeController:ControllerBase
    {

        private readonly GradeServices _service;
        private readonly IMapper _mapper;

        public GradeController(GradeServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/NomController
        [HttpGet]
        public ActionResult<IEnumerable<GradeDTOOut>> GetAllNomController()
        {
            IEnumerable<Grade> listeNomController = _service.GetAllGrades();
            return Ok(_mapper.Map<IEnumerable<GradeDTOOut>>(listeNomController));
        }

        //GET api/NomController/{i}
        [HttpGet("{id}", Name = "GetNomModelById")]
        public ActionResult<GradeDTOOut> GetNomModelById(int id)
        {
            Grade commandItem = _service.GetGradeById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<GradeDTOOut>(commandItem));
            }
            return NotFound();
        }

        //POST api/NomController
        [HttpPost]
        public ActionResult<GradeDTOIn> CreateGrade(Grade obj)
        {
            _service.AddGrade(obj);
            return CreatedAtRoute(nameof(GetNomModelById), new { Id = obj.GradeId }, obj);
        }

        //POST api/NomController/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateGrade(int id, GradeDTOIn obj)
        {
            Grade objFromRepo = _service.GetGradeById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateGrade(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/NomController/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialNomModelUpdate(int id, JsonPatchDocument<Grade> patchDoc)
        {
            Grade objFromRepo = _service.GetGradeById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Grade objToPatch = _mapper.Map<Grade>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateGrade(objFromRepo);
            return NoContent();
        }

        //DELETE api/NomController/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteGrade(int id)
        {
            Grade obj = _service.GetGradeById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteGrade(obj);
            return NoContent();
        }


    }
}
