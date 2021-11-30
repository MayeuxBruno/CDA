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
            return Ok(_mapper.Map<IEnumerable<StudentscourseDtoOutAvecStudentsCourses>>(listeStudentscourse));
        }

        //GET api/Studentscourse/{i}
        [HttpGet("{id}", Name = "GetStudentCourseById")]
        public ActionResult<StudentscourseDtoOutAvecStudentsCourses> GetStudentCourseById(int id)
        {
            Studentscourse commandItem = _service.GetStudentCourseById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<StudentscourseDtoOutAvecStudentsCourses>(commandItem));
            }
            return NotFound();
        }

        //POST api/Studentscourse
        [HttpPost]
        public ActionResult<StudentscourseDtoOutAvecStudentsCourses> CreateNomModel(StudentscourseDtoIn obj)
        {
            Studentscourse newStudentscourse = _mapper.Map<Studentscourse>(obj);
            _service.AddStudentCourse(newStudentscourse);
            return CreatedAtRoute(nameof(GetStudentCourseById), new { Id = newStudentscourse.StudentCourseId }, newStudentscourse);
        }

        //POST api/Studentscourse/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateNomModel(int id, StudentscourseDtoIn obj)
        {
            Studentscourse objFromRepo = _service.GetStudentCourseById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateStudentCourse(objFromRepo);
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
        public ActionResult PartialNomModelUpdate(int id, JsonPatchDocument<Studentscourse> patchDoc)
        {
            Studentscourse objFromRepo = _service.GetStudentCourseById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Studentscourse objToPatch = _mapper.Map<Studentscourse>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateStudentCourse(objFromRepo);
            return NoContent();
        }

        //DELETE api/Studentscourse/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteNomModel(int id)
        {
            Studentscourse obj = _service.GetStudentCourseById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteStudentCourse(obj);
            return NoContent();
        }


    }
}
