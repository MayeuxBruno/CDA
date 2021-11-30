using AutoMapper;
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
    public class StudentscourseController:ControllerBase
    {

        private readonly StudentscourseServices _service;
        private readonly IMapper _mapper;

        public StudentscourseController(StudentscourseServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Studentscourse
        [HttpGet]
        public ActionResult<IEnumerable<StudentscourseDtoOutAvecStudentsCourses>> GetAllStudentscourse()
        {
            IEnumerable<Studentscourse> listeStudentscourse = _service.GetAllStudentscourse();
            return Ok(_mapper.Map<IEnumerable<StudentscourseDto>>(listeStudentscourse));
        }

        //GET api/Studentscourse/{i}
        [HttpGet("{id}", Name = "GetNomModelById")]
        public ActionResult<StudentscourseDTO> GetNomModelById(int id)
        {
            NomModel commandItem = _service.GetNomModelById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<StudentscourseDTO>(commandItem));
            }
            return NotFound();
        }

        //POST api/Studentscourse
        [HttpPost]
        public ActionResult<StudentscourseDTO> CreateNomModel(NomModel obj)
        {
            _service.AddNomModel(obj);
            return CreatedAtRoute(nameof(GetNomModelById), new { Id = obj.Id }, obj);
        }

        //POST api/Studentscourse/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateNomModel(int id, StudentscourseDTO obj)
        {
            NomModel objFromRepo = _service.GetNomModelById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateNomModel(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Studentscourse/{id}
        [HttpPatch("{id}")]
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
        }

        //DELETE api/Studentscourse/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteNomModel(int id)
        {
            NomModel obj = _service.GetNomModelById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteNomModel(obj);
            return NoContent();
        }


    }
}
