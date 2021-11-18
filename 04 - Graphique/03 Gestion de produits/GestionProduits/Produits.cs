using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProduits
{
    public class Produits
    {
        public int IdProduit { get; set; }
        public string LibelleProduit { get; set; }
        public string Categorie  { get; set; }
        public string Rayon { get; set; }

        public Produits(int idProduit, string libelleProduit, string categorie, string rayon)
        {
            IdProduit = idProduit;
            LibelleProduit = libelleProduit;
            Categorie = categorie;
            Rayon = rayon;
        }
    }
}
