using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    class Comptes
    {
        public  int NumCompte { get; set; }
        public Clients Client { get; set; }
        public double Solde { get; private set; }
        private static int Compteur { get; set; } = 0;

        // Constructeur
        public Comptes(Clients client)
        {
            NumCompte = ++Compteur;
            Solde = 0;
            Client = client;
        }

        // Méthodes
        public override string ToString() 
        {
            return "************************\n Numéro du compte : "+this.NumCompte + 
                   "\n Solde du compte : " + this.Solde + "\n Propriétaire du compte " +
                   this.Client.Afficher()+"\n************************";
        }

        // Méthode qui crédite le compte
        public void Crediter(double Somme)
        {
            this.Solde += Somme;
        }

        /// <summary>
        ///Méthode qui crédite une somme au compte et débite le compte passé en paramètre 
        /// </summary>
        /// <param name="Somme">Somme à créditer</param>
        /// <param name="Compte">Compte à débiter</param>
        public void Crediter (double Somme, Comptes Compte)
        {
            this.Crediter(Somme);
            Compte.Debiter(Somme);
        }
      
        // Méthode qui débite une somme au compte
        public void Debiter(double Somme)
        {
            this.Solde -= Somme;
        }

        // Méthode qui débite une somme au compte et crédite le compte passé en paramètre
        public void Debiter (double Somme, Comptes compte)
        {
            this.Debiter(Somme);
            compte.Crediter(Somme);
        }

        // Méthode qui retourne le nombre de comptes créés
        public static void afficherNbComptes ()
        {
            Console.WriteLine("Le nombre de comptes crées est de : "+Compteur);
        }
    }
}
