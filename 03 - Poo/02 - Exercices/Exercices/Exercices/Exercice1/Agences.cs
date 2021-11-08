using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    class Agences
    {
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string Restauration { get; set; }

        //Constructeur
        public Agences(string nom, string adresse, string codePostal, string ville, string restauration)
        {
            this.Nom = nom;
            this.Adresse = adresse;
            this.CodePostal = codePostal;
            this.Ville = ville;
            this.Restauration = restauration;
        }

        public override string ToString()
        {
            return "\n Nom Agence   : " + this.Nom +
                   "\n Adresse      : " + this.Adresse +
                   "\n Code Postal  : " + this.CodePostal +
                   "\n Ville        : " + this.Ville+
                   "\n Restauration : " + this.Restauration;
        }
    }
    

}
