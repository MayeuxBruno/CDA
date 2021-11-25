using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VillesRegions.Data.Models;

namespace VillesRegions.Data.Services
{
    public class DepartementsServices
    {
        private readonly MyDbContext _context;
        public DepartementsServices(MyDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Departement> GetAllDepartements() 
        {
            return _context.Departement.ToList();
        }
    }
}
