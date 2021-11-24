using regions.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace regions.Data.Services
{
    public class VillesServices
    {
        private readonly MyDbContext _context;
        public VillesServices(MyDbContext context)
        {
            _context = context;
        }

        public void AddVille(Villes ville)
        {
            if (ville==null)
            {
                throw new ArgumentNullException(nameof(ville));
            }
            _context.Add(ville);
            _context.SaveChanges();
        }

        public IEnumerable<Villes> GetAllVilles()
        {
            return _context.Villes.ToList();
        }

        public void DeleteVille(Villes ville)
        {
            if(ville==null)
            {
                throw new ArgumentNullException(nameof(ville));
            }
            _context.Remove(ville);
            _context.SaveChanges();
        }

        public Villes GetVilleById(int id)
        {
            return _context.Villes.FirstOrDefault(p => p.IdVille == id);
        }

        public void UpdateVille(int id)
        {
            _context.SaveChanges();
        }
    }
}
