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



namespace School.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradeController:ControllerBase
    {


        private readonly GradeServices _service;
        private readonly IMapper _mapper;

        public GradeController(GradeServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Grade
        [HttpGet]
        public ActionResult<IEnumerable<GradeDTOOutavecStudent>> GetAllGrade()
        {
            IEnumerable<Grade> listeGrade = _service.GetAllGrades();
            return Ok(_mapper.Map<IEnumerable<GradeDTOOutavecStudent>>(listeGrade));
        }

        //GET api/Grade/{i}
        [HttpGet("{id}", Name = "GetGradeById")]
        public ActionResult<GradeDTOOutavecStudent> GetGradeById(int id)
        {
            Grade commandItem = _service.GetGradeById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<GradeDTOOutavecStudent>(commandItem));
            }
            return NotFound();
        }

        //POST api/Grade
        [HttpPost]
        public ActionResult<GradeDTOOutavecStudent> CreateGrade(GradeDTOIn obj)
        {
            Grade newGrade = _mapper.Map<Grade>(obj);
            _service.AddGrade(newGrade);
            return CreatedAtRoute(nameof(GetGradeById), new { Id = newGrade.GradeId }, newGrade);
        }

        //POST api/Grade/{id}
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
        //PATCH api/Grade/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialGradeUpdate(int id, JsonPatchDocument<Grade> patchDoc)
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

        //DELETE api/Grade/{id}
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
