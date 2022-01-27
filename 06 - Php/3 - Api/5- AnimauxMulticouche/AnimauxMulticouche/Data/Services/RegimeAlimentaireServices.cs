using AnimauxMulticouche.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimauxMulticouche.Data.Services
{
    public class RegimeAlimentaireServices
    {

        private readonly MyDbContext _context;

        public RegimeAlimentaireServices(MyDbContext context)
        {
            _context = context;
        }

        public void AddRegimeAlimentaire(Regimesalimentaire obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Regimesalimentaires.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteRegimeAlimentaire(Regimesalimentaire obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Regimesalimentaires.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Regimesalimentaire> GetAllRegimesAlimentaires()
        {
            return _context.Regimesalimentaires.ToList();
        }

        public Regimesalimentaire GetRegimeAlimentaireById(int id)
        {
            return _context.Regimesalimentaires.FirstOrDefault(obj => obj.IdRegimeAlimentaire == id);
        }

        public void UpdateRegimeAlimentaire(Regimesalimentaire obj)
        {
            _context.SaveChanges();
        }


    }
}
