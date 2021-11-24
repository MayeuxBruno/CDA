using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace regions.Data.Models
{
    public class Departements
    {
        [Key]
        public int IdDepartement { get; set; }
        [Required]
        [MaxLength(50)]
        public string NomDepartement { get; set; }
        public List<Villes> ListeVilles { get; set; }
    }
}
