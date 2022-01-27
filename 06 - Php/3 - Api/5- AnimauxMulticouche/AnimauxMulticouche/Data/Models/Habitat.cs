using System;
using System.Collections.Generic;

#nullable disable

namespace AnimauxMulticouche.Data.Models
{
    public partial class Habitat
    {
        public Habitat()
        {
            Animaux = new HashSet<Animal>();
        }

        public int IdHabitat { get; set; }
        public string LibelleHabitat { get; set; }

        public virtual ICollection<Animal> Animaux { get; set; }
    }
}
