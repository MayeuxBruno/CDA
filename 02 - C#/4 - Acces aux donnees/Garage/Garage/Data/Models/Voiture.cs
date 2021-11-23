using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Garage.Data.Models.DbModels
{
    public partial class Voiture
    {
        [Key]
        public int IdVoiture { get; set; }
        public string Marque { get; set; }
        public string Modele { get; set; }
        public string Couleur { get; set; }
    }
}
