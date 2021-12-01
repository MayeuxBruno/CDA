using GestionStock.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Data.Services
{
    class ArticleServices
    {
        private readonly MyDbContext _context;
        public ArticleServices(MyDbContext context)
        {
            _context = context;
        }

        public void AddArticle(Article article)
        {
            if (article == null)
            {
                throw new ArgumentNullException(nameof(article));
            }
            _context.Add(article);
            _context.SaveChanges();
        }

        public IEnumerable<Article> GetAllArticles()
        {
            return _context.Articles.ToList();
        }

        public void DeleteArticle(Article article)
        {
            if (article == null)
            {
                throw new ArgumentNullException(nameof(article));
            }
            _context.Remove(article);
            _context.SaveChanges();
        }

        public Article GetArticleById(int id)
        {
            return _context.Articles.FirstOrDefault(p => p.IdArticle == id);
        }

        public void UpdateArticle(Article obj)
        {
            _context.SaveChanges();
        }
    }
}