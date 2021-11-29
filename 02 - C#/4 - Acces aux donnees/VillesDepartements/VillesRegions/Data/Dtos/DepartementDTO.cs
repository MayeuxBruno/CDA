using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VillesRegions.Data.Models;

namespace VillesRegions.Data.Dtos
{
    public class DepartementDTO
    {
        public string LibelleDepartement { get; set; }
        public ICollection<VilleDTOIn> LesVilles { get; set; }
    }
}
