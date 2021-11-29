using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TablesRelation.Data.Models;
using TablesRelation.Models.DbModels;

namespace TablesRelation.Data.Services
{
    public class CategoryServices
    {

        private readonly gestionstockContext _context;

        public CategoryServices(gestionstockContext context)
        {
            _context = context;
        }

        public void AddCategory(Category obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Categories.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteCategory(Category obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Categories.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Category> GetAllCategory()
        {
            return _context.Categories.Include("TypesProduits").ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _context.Categories.FirstOrDefault(obj => obj.IdCategorie == id);
        }

        public void UpdateCategory(Category obj)
        {
            _context.SaveChanges();
        }


    }
}
