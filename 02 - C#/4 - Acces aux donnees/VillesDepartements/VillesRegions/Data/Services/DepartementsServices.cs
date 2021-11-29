using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VillesRegions.Data.Dtos;
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

        /*public IEnumerable<Departement> GetAllDepartements() 
        {
            return _context.Departement.ToList();
        }*/

        public IEnumerable<Departement> GetAllDepartements()
        {
            var liste = (from dept in _context.Departement
                         join ville in _context.Ville
                         on dept.IdDepartement equals ville.IdDepartement
                         select new Departement
                         {
                             IdDepartement = dept.IdDepartement,
                             LibelleDepartement = dept.LibelleDepartement,
                             LesVilles = _context.Ville.Where(v=>v.IdDepartement==dept.IdDepartement).ToList()
                         }).ToList();
            return liste;
        }
    }
}
