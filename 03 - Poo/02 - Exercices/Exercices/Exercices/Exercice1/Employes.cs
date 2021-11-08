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

        // Constructeur
        public Employes(string nom, string prenom, DateTime date, string fonction, double salaireBrutAnnuel, string service)
        {
            Nom = nom;
            Prenom = prenom;
            DateEmbauche = date;
            Fonction = fonction;
            SalaireBrutAnnuel = salaireBrutAnnuel;
            Service = service;
        }

        //Méthodes

        // Affiche la fiche d'un employé
        public override string ToString()
        {
            return "\n************************" +
                   "\n Fiche Employe" +
                   "\n************************" +
                   "\n Nom : " + this.Nom + "\n Prénom : " + this.Prenom +
                   "\n Date d'embuache : "+this.DateEmbauche.ToString("dd/MM/yyyy")+
                   "\n Fonction : " + this.Fonction + "\n Salaire Brut Annuel :" + this.SalaireBrutAnnuel +
                   "\n Service : " + this.Service;
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

        public string VirementPrime()
        {
            double prime = this.CalculPrime();
            DateTime moment = DateTime.Today;
            DateTime DateVirement = new DateTime(moment.Year, 11, 9);
            if (moment>=DateVirement)
            {
                return "L'ordre de transfert a bien ete transmis à la banque pour la somme de " + prime + " Euros.";
            }
            else
            {
                return "L'ordre de virement n'a pas été transmis";
            }
        }
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
    }
}
