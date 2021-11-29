using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TablesRelation.Data.Models;
using TablesRelation.Models.DbModels;

namespace TablesRelation.Data.Services
{
    public class ArticleServices
    {

        private readonly gestionstockContext _context;

        public ArticleServices(gestionstockContext context)
        {
            _context = context;
        }

        public void AddArticle(Article obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Articles.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteArticle(Article obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Articles.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Article> GetAllArticle()
        {
            return _context.Articles.ToList();
        }

        public Article GetArticleById(int id)
        {
            return _context.Articles.FirstOrDefault(obj => obj.IdArticle == id);
        }

        public void UpdateArticle(Article obj)
        {
            _context.SaveChanges();
        }




    }
}
