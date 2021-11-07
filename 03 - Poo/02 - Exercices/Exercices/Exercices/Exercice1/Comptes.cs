using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    class Comptes
    {
        private  int NumCompte { get; set; }
        private double Solde { get; set; }
        private Clients Client { get; set; }
        private static int Compteur=0;

        // Constructeur
        public Comptes(double solde, Clients client)
        {
            NumCompte = ++Compteur;
            Solde = solde;
            Client = client;
        }

        // Méthodes
        public override string ToString() 
        {
            return "************************\n Numéro du compte : "+this.NumCompte + 
                   "\n Solde du compte : " + this.Solde + "\n Propriétaire du compte " +
                   this.Client.Afficher()+"\n************************";
        }

        public void Crediter(double Somme)
        {
            this.Solde += Somme;
        }
        public void Crediter (double Somme, Comptes Compte)
        {
            this.Crediter(Somme);
            Compte.Debiter(Somme);
        }
        public void Debiter(double Somme)
        {
            this.Solde -= Somme;
        }
        public void Debiter (double Somme, Comptes compte)
        {
            this.Debiter(Somme);
            compte.Crediter(Somme);
        }
        public static int NbComptes ()
        {
            return Compteur;
        }
    }
}
