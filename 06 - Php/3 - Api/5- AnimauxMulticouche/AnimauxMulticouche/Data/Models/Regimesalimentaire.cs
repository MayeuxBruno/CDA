using System;
using System.Collections.Generic;

#nullable disable

namespace AnimauxMulticouche.Data.Models
{
    public partial class Regimesalimentaire
    {
        public Regimesalimentaire()
        {
            Animaux = new HashSet<Animal>();
        }

        public int IdRegimeAlimentaire { get; set; }
        public string LibelleRegimeAlimentaire { get; set; }

        public virtual ICollection<Animal> Animaux { get; set; }
    }
}
