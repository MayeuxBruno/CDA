using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VillesRegions.Data.Dtos
{
    public class VilleDTOUpdate
    {
        public int IdVille { get; set; }
        public string LibelleVille { get; set; }
        public int IdDepartement { get; set; }
    }
}
