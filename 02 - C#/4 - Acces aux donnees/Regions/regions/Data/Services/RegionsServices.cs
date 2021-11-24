using regions.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace regions.Data.Services
{
    public class RegionsServices
    {
        public readonly MyDbContext _context;
        public RegionsServices(MyDbContext context)
        {
            _context = context;
        }

        public void AddRegion(Regions region)
        {
            if (region == null)
            {
                throw new ArgumentNullException(nameof(region));
            }
            _context.Add(region);
            _context.SaveChanges();
        }

        public IEnumerable<Regions> GetAllRegions()
        {
            return _context.Regions.ToList();
        }

        public Regions GetRegionById(int id)
        {
            return _context.Regions.FirstOrDefault(r => r.IdRegion == id);
        }

        public void UpdateRegion(Regions region)
        {
            _context.SaveChanges();
        }

        public void Delete(Regions region)
        {
            if (region==null)
            {
                throw new ArgumentNullException(nameof(region));
            }
            _context.Regions.Remove(region);
            _context.SaveChanges();
        }
    }
}
