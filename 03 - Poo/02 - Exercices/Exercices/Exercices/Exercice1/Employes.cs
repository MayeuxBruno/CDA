using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    class Employes
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateEmbauche { get; set; }
        public string Fonction { get; set; }
        public double SalaireBrutAnnuel { get; set; }
        public string Service { get; set; }
        public Agences Agence { get; set; }

        // Constructeur
        public Employes(string nom, string prenom, DateTime date, string fonction, double salaireBrutAnnuel, string service, Agences agence)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateEmbauche = date;
            this.Fonction = fonction;
            this.SalaireBrutAnnuel = salaireBrutAnnuel;
            this.Service = service;
            this.Agence = agence;
        }

        //Méthodes

        // Affiche la fiche d'un employé
        public override string ToString()
        {
            return "\n******************************************************" +
                   "\n                     Fiche Employe" +
                   "\n******************************************************" +
                   "\n Nom                 : " + this.Nom + 
                   "\n Prénom              : " + this.Prenom +
                   "\n Date d'embuache     : "+this.DateEmbauche.ToString("dd/MM/yyyy")+
                   "\n Fonction            : " + this.Fonction + 
                   "\n Salaire Brut Annuel : " + this.SalaireBrutAnnuel +
                   "\n Service             : " + this.Service+
                   "\n Cet employe "+(this.ChequesVacances()?"bénéficie":"ne bénéficie pas")+" de chèques vacances."+
                   "\n\n Agence : "+this.Agence+"\n";
        }

        // Retourne l'ancienneté de l'employé
        public int Anciennete()
        {
            DateTime DateActuelle = DateTime.Today;
            TimeSpan anciennete = (DateActuelle-this.DateEmbauche);
            return (int)anciennete.Days / 365;
        }

        // Calcule la prime de l'employe
        public double CalculPrime()
        {
            double anciennete = Convert.ToDouble(this.Anciennete());
            double prime = (this.SalaireBrutAnnuel * 0.05) + ((this.SalaireBrutAnnuel*0.02)*anciennete);
            return prime;
        }

        /// <summary>
        /// Retourne la masse salariale de l'Employe
        /// </summary>
        /// <returns>masse salariale (double)</returns>
        public double MasseSalariale()
        {
            return this.SalaireBrutAnnuel + CalculPrime();
        }
      
        /// <summary>
        /// Indique si l'employe à le droit aux chèques vacances
        /// </summary>
        /// <returns>boolen false n'a pas le droit, true a le droit</returns>
        public bool ChequesVacances()
        {
            if (this.Anciennete() > 1) return true;
            return false;
        }

        /// <summary>
        /// Tri les employés par nom et prénom
        /// </summary>
        /// <param name="a">Employé a</param>
        /// <param name="b">Employé b</param>
        /// <returns>int -1;0;1</returns>
        public static int CompareByName(Employes a, Employes b)
        {
            if ((a.Nom.CompareTo(b.Nom)) > 0)
            {
                return 1;
            }
            else if((a.Nom.CompareTo(b.Nom)) < 0)
            {
                return -1;
            }
            else if ((a.Prenom.CompareTo(b.Prenom)) > 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }

        }

        /// <summary>
        /// Compare les employes par Service puis par nom et prénom
        /// </summary>
        /// <param name="a">Employé a</param>
        /// <param name="b">Employe b</param>
        /// <returns>Int -1;0;1</returns>
        public static int CompareByServiceNom(Employes a, Employes b)
        {
            if ((a.Service.CompareTo(b.Service)) > 0)
            {
                return 1;
            }
            else if((a.Service.CompareTo(b.Service)) < 0)
            {
                return -1;
            }
            else
            {
                return CompareByName(a,b);
            }
        }
        
    }
}
