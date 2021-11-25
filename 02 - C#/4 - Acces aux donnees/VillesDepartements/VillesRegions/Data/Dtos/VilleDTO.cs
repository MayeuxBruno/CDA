using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VillesRegions.Data.Dtos
{
    public class VilleDTO
    {
        public string LibelleVille { get; set; }
        public DepartementDTO Dep { get; set; }
    }
}
