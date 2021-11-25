using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VillesRegions.Data.Models;

namespace VillesRegions.Data.Services
{
    public class VillesServices
    {
        private readonly MyDbContext _context;
        public VillesServices(MyDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Ville> GetAllVilles()
        {
            var liste = (from ville in _context.Ville
                         join dept in _context.Departement
                         on ville.IdDepartement equals dept.IdDepartement
                         select new Ville
                         {
                             IdVille = ville.IdVille,
                             LibelleVille = ville.LibelleVille,
                             IdDepartement = ville.IdDepartement,
                             Dep = dept
                         }).ToList();
            return liste;
        }
        // return _context.Ville.ToList();
    }
    }
