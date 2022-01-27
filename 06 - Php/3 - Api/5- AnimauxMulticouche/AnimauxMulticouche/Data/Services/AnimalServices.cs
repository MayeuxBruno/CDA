using AnimauxMulticouche.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimauxMulticouche.Data.Services
{
    
    public class AnimalServices
    {
        private readonly MyDbContext _context;
        public AnimalServices(MyDbContext context)
        {
            _context = context;
        }

        public void AddAnimal(Animal obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Animaux.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteAnimal(Animal obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Animaux.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Animal> GetAllAnimaux()
        {
            return _context.Animaux.Include("SonHabitat").Include("SonRegimeAlimentaire").ToList();
        }

        public Animal GetAnimalById(int id)
        {
            return _context.Animaux.Include("SonHabitat").Include("SonRegimeAlimentaire").FirstOrDefault(obj => obj.IdAnimal == id);
        }

        public void UpdateAnimal(Animal obj)
        {
            _context.SaveChanges();
        }


    }
}
