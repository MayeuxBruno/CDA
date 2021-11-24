using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelToBase.Data
{
    public class Personnes
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Prenom { get; set; }
        [MaxLength(50)]
        public string Nom { get; set; }
        public int Age { get; set; }
    }
}
