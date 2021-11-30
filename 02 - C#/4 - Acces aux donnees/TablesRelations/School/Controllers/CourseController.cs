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
    public class CourseController:ControllerBase
    {

        private readonly CourseServices _service;
        private readonly IMapper _mapper;

        public CourseController(CourseServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Course
        [HttpGet]
        public ActionResult<IEnumerable<CourseDtoOut>> GetAllCourse()
        {
            IEnumerable<Course> listeCourse = _service.GetAllCourses();
            return Ok(_mapper.Map<IEnumerable<CourseDtoOut>>(listeCourse));
        }

        //GET api/Course/{i}
        [HttpGet("{id}", Name = "GetCourseById")]
        public ActionResult<CourseDtoOut> GetCourseById(int id)
        {
            Course commandItem = _service.GetCourseById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<CourseDtoOut>(commandItem));
            }
            return NotFound();
        }

        //POST api/Course
        [HttpPost]
        public ActionResult<CourseDtoOut> CreateCourse(CourseDtoIn obj)
        {
            Course newCourse = _mapper.Map<Course>(obj);
            _service.AddCourse(newCourse);
            return CreatedAtRoute(nameof(GetCourseById), new { Id = newCourse.CourseId }, newCourse);
        }

        //POST api/Course/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateCourse(int id, CourseDtoIn obj)
        {
            Course objFromRepo = _service.GetCourseById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateCourse(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Course/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialCourseUpdate(int id, JsonPatchDocument<Course> patchDoc)
        {
            Course objFromRepo = _service.GetCourseById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Course objToPatch = _mapper.Map<Course>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateCourse(objFromRepo);
            return NoContent();
        }

        //DELETE api/Course/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteCourse(int id)
        {
            Course obj = _service.GetCourseById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteCourse(obj);
            return NoContent();
        }


    }
}
