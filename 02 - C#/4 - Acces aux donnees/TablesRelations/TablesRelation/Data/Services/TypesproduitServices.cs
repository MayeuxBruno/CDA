using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TablesRelation.Data.Models;
using TablesRelation.Models.DbModels;

namespace TablesRelation.Data.Services
{
    public class TypesproduitServices
    {

        private readonly gestionstockContext _context;

        public TypesproduitServices(gestionstockContext context)
        {
            _context = context;
        }

        public void AddTypeProduit(Typesproduit obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Typesproduits.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteTypeProduit(Typesproduit obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Typesproduits.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Typesproduit> GetAllTypesProduit()
        {
            return _context.Typesproduits.Include("Categories").ToList();
        }

        public Typesproduit GetTypeProduitById(int id)
        {
            return _context.Typesproduits.FirstOrDefault(obj => obj.IdTypeProduit == id);
        }

        public void UpdateTypeProduit(Typesproduit obj)
        {
            _context.SaveChanges();
        }


    }
}
