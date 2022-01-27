using AnimauxMulticouche.Data.Dto;
using System;
using System.Collections.Generic;

#nullable disable

namespace AnimauxMulticouche.Data.Models
{
    public partial class Animal
    {
        public int IdAnimal { get; set; }
        public string NomAnimal { get; set; }
        public int IdRegimeAlimentaire { get; set; }
        public int IdHabitat { get; set; }

        public virtual Habitat SonHabitat { get; set; }
        public virtual Regimesalimentaire SonRegimeAlimentaire { get; set; }
    }
}
