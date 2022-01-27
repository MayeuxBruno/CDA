using AnimauxMulticouche.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimauxMulticouche.Data.Services
{
    public class HabitatServices
    {

        private readonly MyDbContext _context;

        public HabitatServices(MyDbContext context)
        {
            _context = context;
        }

        public void AddHabitat(Habitat obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Habitats.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteHabitat(Habitat obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Habitats.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Habitat> GetAllHabitats()
        {
            return _context.Habitats.ToList();
        }

        public Habitat GetHabitatById(int id)
        {
            return _context.Habitats.FirstOrDefault(obj => obj.IdHabitat == id);
        }

        public void UpdateHabitat(Habitat obj)
        {
            _context.SaveChanges();
        }


    }
}
