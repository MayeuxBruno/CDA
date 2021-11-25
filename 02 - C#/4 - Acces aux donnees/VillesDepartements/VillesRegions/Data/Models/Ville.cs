using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace VillesRegions.Data.Models
{
    public partial class Ville
    {
        [Key]
        public int IdVille { get; set; }
        public string LibelleVille { get; set; }
        public int IdDepartement { get; set; }
        public Departement Dep { get; set; }
    }
}
