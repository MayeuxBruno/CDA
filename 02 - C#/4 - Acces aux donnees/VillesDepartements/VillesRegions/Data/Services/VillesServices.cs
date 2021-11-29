using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VillesRegions.Data.Models;
using VillesRegions.Data.Dtos;

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
        
        public Ville GetVilleById(int id)
        {
            var item = (from ville in _context.Ville
                        join dept in _context.Departement
                        on ville.IdDepartement equals dept.IdDepartement
                        select new Ville
                        {
                            IdVille = ville.IdVille,
                            LibelleVille = ville.LibelleVille,
                            IdDepartement = ville.IdDepartement,
                            Dep = dept
                        }).FirstOrDefault(e=>e.IdVille==id);
            return item;
        }

        public void AddVille(VilleDTOIn ville)
        {
            if (ville==null)
            {
                throw new ArgumentNullException(nameof(ville));
            }
            var entite = new Ville()
            {
                LibelleVille = ville.LibelleVille,
                IdDepartement=ville.IdDepartement
            };
            _context.Add(entite);
            _context.SaveChanges();
        }

        public void UpdateVille(Ville ville)
        {
            if (ville==null)
            {
                throw new ArgumentNullException(nameof(ville));
            }
            var entite = new Ville()
            {
                IdVille = ville.IdVille,
                LibelleVille = ville.LibelleVille,
                IdDepartement = ville.IdDepartement
            };
            _context.Update(entite);
            _context.SaveChanges();
        }
    }
    }
