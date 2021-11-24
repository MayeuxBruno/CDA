using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace regions.Data.Models
{
    public class Villes
    {
        [Key]
        public int IdVille { get; set; }
        [Required]
        [MaxLength(50)]
        public string NomVille { get; set; }
        
    }
}
