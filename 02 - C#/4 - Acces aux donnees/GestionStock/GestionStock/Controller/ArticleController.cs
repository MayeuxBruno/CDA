using AutoMapper;
using GestionStock.Data;
using GestionStock.Data.Models;
using GestionStock.Data.Profiles;
using GestionStock.Data.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Controller
{
    class ArticleController:ControllerBase
    {
        private readonly ArticleServices _service;
        private readonly IMapper _mapper;

        public ArticleController(MyDbContext _context)
        {
            _service = new ArticleServices(_context);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ArticleProfile>();
            });
            _mapper = config.CreateMapper();
        }

        public ActionResult<IEnumerable<Article>> GetAllArticles()
        {
            IEnumerable<Article> listeCourse = _service.GetAllArticles();
            return Ok(_mapper.Map<IEnumerable<Article>>(listeCourse));
        }

        public ActionResult<Article> GetCourseById(int id)
        {
            Article commandItem = _service.GetArticleById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<Article>(commandItem));
            }
            return NotFound();
        }
        public ActionResult<Article> CreateArticle(Article obj)
        {
            Article newCourse = _mapper.Map<Article>(obj);
            _service.AddArticle(newCourse);
            return CreatedAtRoute(nameof(GetCourseById), new { Id = newCourse.IdArticle }, newCourse);
        }
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
      
       /* 
        public ActionResult PartialCourseUpdate(int id, JsonPatchDocument<Article> patchDoc)
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
        }
       */
       
        public ActionResult DeleteCourse(int id)
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
