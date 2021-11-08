using System;
using System.Collections.Generic;

namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Classe Voitures*/
            /*Voitures v1 = new Voitures("Citroen","C4");
            v1.NbKilometres = 10000;
            Voitures v2 = new Voitures("Renault", "Kadjar");
            v2.Couleur = "Rouge";
            Console.WriteLine(v1);
            Console.WriteLine(v2);
            v1.Rouler(5000);
            Console.WriteLine(v1);*/


            /*Classe Comptes*/
            /*Clients c1= new Clients("0212121", "Duarand", "Toto","0695128935");
            Clients c2 = new Clients("5698785", "Dupont", "Jacques", "0589654120");
            Clients c3 = new Clients("9512326", "Morin", "Serge", "0201569878");
            Comptes Cpt1 = new Comptes(2000, c1);
            Comptes Cpt2 = new Comptes(200, c2);
            Comptes Cpt3 = new Comptes(10000, c3);
            Console.WriteLine(Cpt1.ToString());
            Console.WriteLine(Cpt2.ToString());
            Console.WriteLine(Cpt3.ToString());
            Cpt1.Crediter(100, Cpt2);
            Cpt3.Debiter(3000, Cpt2);
            Console.WriteLine(Cpt1.ToString());
            Console.WriteLine(Cpt2.ToString());
            Console.WriteLine(Cpt3.ToString());
            Console.WriteLine("\nNombre de Compte crées : " + Comptes.NbComptes());*/

            /*Classe Employes*/
            //Employes e1 = new Employes("Dupont", "Jordan", new DateTime(1986, 12, 17),"Ouvrier",17000,"Menuiserie");
            //Employes e2 = new Employes("Durand", "Céline", new DateTime(2007, 05, 02), "Secrétaire", 27000, "Direction");
            //Console.WriteLine(e1.ToString());
            //Console.WriteLine(e1.Anciennete());
            //Console.WriteLine(e1.CalculPrime());
            //Console.WriteLine(e2.ToString());
            //Console.WriteLine(e2.Anciennete());
            //Console.WriteLine(e2.CalculPrime());
            //Console.WriteLine(e2.VirementPrime());

            double masseSalariale=0;
            List<Employes>emp = new List<Employes> ();
            Agences a1 = new Agences("Agence 1", "12 Rue de Dunkerque", "59632", "Bergues","Restaurant Entreprise");
            emp.Add(new Employes("Dupont", "Jordan", new DateTime(1986, 12, 17), "Ouvrier", 17000, "Menuiserie",a1));
            emp.Add(new Employes("Dupont", "Céline", new DateTime(2007, 05, 02), "Secrétaire", 27000, "Direction",a1));
            emp.Add(new Employes("Morin", "Bernard", new DateTime(2021, 11, 02), "Comptable", 27500, "Comptabilité",a1));
            emp.Add(new Employes("Dul", "Cécile", new DateTime(2004, 10, 12), "Secrétaire", 21000, "Comptabilité",a1));
            emp.Add(new Employes("Billot", "Jacques", new DateTime(2007, 02, 07), "Commercial", 25600, "Commercial",a1));


            Enfants enf1 = new Enfants("Dupont", "Rémi", new DateTime(2006, 12, 11));
            Console.WriteLine(enf1.ToString());
            // Nombre d'employes dans l'entreprise
            Console.WriteLine("\nLe nombre d'employés est de : " + emp.Count+"\n");

            // Virement des Primes
            DateTime moment = DateTime.Today;
            DateTime DateVirement = new DateTime(moment.Year, 11, 8);
            if (moment >= DateVirement)
            {
                foreach (var item in emp)
                {
                    Console.WriteLine("L'ordre de transfert a bien ete transmis à la banque pour la somme de " + item.CalculPrime() + " Euros.");

                }
            }
            else
            {
                Console.WriteLine("L'ordre de virement n'a pas été transmis");
            }


            // Tri de la liste
            //emp.Sort(Employes.CompareByName);
            emp.Sort(Employes.CompareByServiceNom);
            foreach (Employes item in emp)
            {
                Console.WriteLine(item.ToString());
            }

            // Calcul de la masse salariale de l'entreprise
            foreach (Employes item in emp)
            {
                masseSalariale += item.MasseSalariale();
            }
            Console.WriteLine("La Masse Salariale de l'entreprise est de " + masseSalariale + " Euros.");



        }
    }
}
