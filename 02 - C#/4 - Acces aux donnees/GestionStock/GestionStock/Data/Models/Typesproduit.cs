using System;
using System.Collections.Generic;

#nullable disable

namespace GestionStock.Data.Models
{
    public partial class Typesproduit
    {
        public Typesproduit()
        {
            Categories = new HashSet<Categorie>();
        }

        public int IdTypeProduit { get; set; }
        public string LibelleTypeProduit { get; set; }

        public virtual ICollection<Categorie> Categories { get; set; }
    }
}
