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
    public class StudentController:ControllerBase
    {

        private readonly StudentServices _service;
        private readonly IMapper _mapper;

        public StudentController(StudentServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Student
        [HttpGet]
        public ActionResult<IEnumerable<StudentDtoOutavecGrade>> GetAllStudents()
        {
            IEnumerable<Student> listeStudent = _service.GetAllStudents();
            return Ok(_mapper.Map<IEnumerable<StudentDtoOutavecGrade>>(listeStudent));
        }

        //GET api/Student/{i}
        [HttpGet("{id}", Name = "GetNomModelById")]
        public ActionResult<StudentDtoOutavecGrade> GetStudentById(int id)
        {
            Student commandItem = _service.GetStudentById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<StudentDtoOutavecGrade>(commandItem));
            }
            return NotFound();
        }

        //POST api/Student
        [HttpPost]
        public ActionResult<StudentDtoIn> CreateStudent(Student obj)
        {
            _service.AddStudent(obj);
            return CreatedAtRoute(nameof(GetStudentById), new { Id = obj.StudentId }, obj);
        }

        //POST api/Student/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateNomModel(int id, StudentDtoIn obj)
        {
            Student objFromRepo = _service.GetStudentById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateStudent(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Student/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialNomModelUpdate(int id, JsonPatchDocument<Student> patchDoc)
        {
            Student objFromRepo = _service.GetStudentById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Student objToPatch = _mapper.Map<Student>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateStudent(objFromRepo);
            return NoContent();
        }

        //DELETE api/Student/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteNomModel(int id)
        {
            Student obj = _service.GetStudentById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteStudent(obj);
            return NoContent();
        }


    }
}
