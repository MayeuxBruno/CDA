using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TablesRelation.Data.Dto;
using TablesRelation.Data.Models;
using TablesRelation.Data.Services;

namespace TablesRelation.Controllers
{
    [Route("api/Article")]
    [ApiController]
    public class ArticleController:ControllerBase
    {
        
        private readonly ArticleServices _service;
        private readonly IMapper _mapper;

        public ArticleController(ArticleServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Article
        [HttpGet]
        public ActionResult<IEnumerable<ArticleDTO>> GetAllArticle()
        {
            IEnumerable<Article> listeArticle = _service.GetAllArticle();
            return Ok(_mapper.Map<IEnumerable<ArticleDTO>>(listeArticle));
        }

        //GET api/Article/{i}
        [HttpGet("{id}", Name = "GetArticleById")]
        public ActionResult<Article> GetArticleById(int id)
        {
            Article commandItem = _service.GetArticleById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<Article>(commandItem));
            }
            return NotFound();
        }

        //POST api/Article
        [HttpPost]
        public ActionResult<Article> CreateArticle(Article obj)
        {
            _service.AddArticle(obj);
            return CreatedAtRoute(nameof(GetArticleById), new { Id = obj.IdArticle }, obj);
        }

        //POST api/Article/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateArticle(int id, Article obj)
        {
            Article objFromRepo = _service.GetArticleById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateArticle(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Article/{id}
        /*[HttpPatch("{id}")]
        public ActionResult PartialArticleUpdate(int id, JsonPatchDocument<Article> patchDoc)
        {
            Article objFromRepo = _service.GetArticleById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Article objToPatch = _mapper.Map<Article>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateArticle(objFromRepo);
            return NoContent();
        }*/

        //DELETE api/Article/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteArticle(int id)
        {
            Article obj = _service.GetArticleById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteArticle(obj);
            return NoContent();
        }


    }
}
