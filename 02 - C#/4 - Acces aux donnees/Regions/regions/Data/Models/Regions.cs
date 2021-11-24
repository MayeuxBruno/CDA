using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace regions.Data
{
    public class Regions
    {
        [Key]
        public int IdRegion { get; set; }
        [Required]
        [MaxLength(50)]
        public string NomRegion { get; set; }
        public List<Departements> ListeDepartements { get; set; }
    }
}
