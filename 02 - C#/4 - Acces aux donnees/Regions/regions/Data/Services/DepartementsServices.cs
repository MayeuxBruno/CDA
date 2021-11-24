using regions.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace regions.Data.Services
{
    public class DepartementsServices
    {
        private readonly MyDbContext _context;
        public DepartementsServices (MyDbContext context)
        {
            _context = context;
        }

        public void AddDepartement(Departements departement)
        {
            if (departement==null)
            {
                throw new ArgumentNullException(nameof(departement));
            }
        }

        public IEnumerable<Departements> GetAllDepartement()
        {
            return _context.Departements.ToList();
        }

        public Departements GetDepartementById(int id)
        {
            return _context.Departements.FirstOrDefault(d => d.IdDepartement == id);
        }

        public void UpdateDepartement(Departements departement)
        {
            _context.SaveChanges();
        }

        public void DeleteDepartement(Departements departement)
        {
            if (departement==null)
            {
                throw new ArgumentNullException(nameof(departement));
            }
            _context.Departements.Remove(departement);
            _context.SaveChanges();
        }
    }

    
}
