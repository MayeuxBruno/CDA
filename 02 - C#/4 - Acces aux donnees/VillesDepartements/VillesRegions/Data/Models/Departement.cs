using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace VillesRegions.Data.Models
{
    public partial class Departement
    {
        [Key]
        public int IdDepartement { get; set; }
        public string LibelleDepartement { get; set; }
        public ICollection<Ville> LesVilles { get; set; }
    }
}
