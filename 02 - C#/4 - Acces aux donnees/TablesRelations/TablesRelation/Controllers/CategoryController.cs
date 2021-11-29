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
    [Route("api/Category")]
    [ApiController]
    public class CategoryController:ControllerBase
    {

        private readonly CategoryServices _service;
        private readonly IMapper _mapper;

        public CategoryController(CategoryServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/
        [HttpGet]
        public ActionResult<IEnumerable<Category>> GetAllCategory()
        {
            IEnumerable<Category> liste = _service.GetAllCategory();
            return Ok(_mapper.Map<IEnumerable<Category>>(liste));
        }

        //GET api//{i}
        [HttpGet("{id}", Name = "GetCategoryById")]
        public ActionResult<Category> GetCategoryById(int id)
        {
            Category commandItem = _service.GetCategoryById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<Category>(commandItem));
            }
            return NotFound();
        }

        //POST api/
        [HttpPost]
        public ActionResult<Category> CreateCategory(Category obj)
        {
            _service.AddCategory(obj);
            return CreatedAtRoute(nameof(GetCategoryById), new { Id = obj.IdCategorie }, obj);
        }

        //POST api//{id}
        [HttpPut("{id}")]
        public ActionResult UpdateCategory(int id, Category obj)
        {
            Category objFromRepo = _service.GetCategoryById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateCategory(objFromRepo);
            return NoContent();
        }

        /*
        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api//{id}
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
        }*/

        //DELETE api//{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteCategory(int id)
        {
            Category obj = _service.GetCategoryById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteCategory(obj);
            return NoContent();
        }


    }
}
