using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    class Voitures
    {
        public string Couleur { get; set; }
        public string Marque { get; set; }
        public string Modele { get; set; }
        public int NbKilometres { get; set; }
        public string Motorisation { get; set; }

        //Constructeurs
       

        public Voitures(string couleur, string marque, string modele, int nbKilometres, string motorisation)
        {
            Couleur = couleur;
            Marque = marque;
            Modele = modele;
            NbKilometres = nbKilometres;
            Motorisation = motorisation;
        }
        public Voitures(string marque, string modele)
        {
            Marque = marque;
            Modele = modele;
        }

        //Methodes

        public override string ToString()
        {
            return "\nCette voiture est une "+this.Modele+" de la marque "+this.Marque+" de couleur "+this.Couleur+
                   " de motorisation "+this.Motorisation+", avec "+this.NbKilometres+" Kilomètres";
        }

        public void Rouler(int NbKms)
        {
            this.NbKilometres += NbKms;
        }
    }

    
}
