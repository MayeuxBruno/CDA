using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    class Enfants
    {
        public string Nom { get; set; }
        public string Prenom  { get; set; }
        public DateTime DateDeNaissance { get; set; }

        public Enfants(string nom, string prenom, DateTime dateDeNaissance)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateDeNaissance = dateDeNaissance;
        }
        public override string ToString()
        {
            return "\nNom de l'enfant    : " + this.Nom +
                   "\nPrenom de l'enfant : " + this.Prenom +
                   "\nDate de Naissance  : " + this.DateDeNaissance.ToString("dd/MM/yyyy") +
                   "\nChèque de Noel     : " + this.ChequeNoel();
        }

        /// <summary>
        /// Retourne l'age de l'enfant
        /// </summary>
        /// <returns>int Age de l'enfant</returns>
        public int Age()
        {
            DateTime DateActuelle = DateTime.Today;
            TimeSpan anciennete = (DateActuelle - this.DateDeNaissance);
            return (int)anciennete.Days / 365;
        }

        /// <summary>
        /// Indique si l'enfant peux recevoir un chèque de noel 
        /// </summary>
        /// <returns>int valeur du chèque</returns>
        public int ChequeNoel ()
        {
            int age = this.Age();
            if (age>=0 && age <11)
            {
                return 20;
            }
            else if(age<16)
            {
                return 30;
            }
            else if(age<=18)
            {
                return 50;
            }
            return 0;
        }
    }
}
