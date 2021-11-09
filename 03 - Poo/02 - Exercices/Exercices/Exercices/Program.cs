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
            Agences a2 = new Agences("Agence 2", "25 Rue de Lille", "62400", "Béthune", "Tickets Restaurant");
            Agences a3 = new Agences("Agence 3", "25 Rue de d'Amiens", "62000", "Arras", "Restaurant Entreprise");

            Enfants enf1 = new Enfants("Dupont", "Rémi", new DateTime(2010, 12, 11));
            Enfants enf2 = new Enfants("Dupont", "Eloise", new DateTime(2010, 12, 06));
            Enfants enf3 = new Enfants("Billot", "Marc", new DateTime(2008, 01, 02));
            Enfants enf4 = new Enfants("Morin", "Kévin", new DateTime(2002, 02, 02));

            emp.Add(new Employes("Durand", "Jordan", new DateTime(1986, 12, 17), "Ouvrier", 17000, "Menuiserie", a1,new List<Enfants>() {}));
            emp.Add(new Employes("Dupont", "Céline", new DateTime(2007, 05, 02), "Secrétaire", 27000, "Direction", a2, new List<Enfants>() { enf1, enf2 }));
            emp.Add(new Employes("Morin", "Bernard", new DateTime(2021, 11, 02), "Comptable", 27500, "Comptabilité", a2, new List<Enfants>() { enf4 }));
            emp.Add(new Employes("Dul", "Cécile", new DateTime(2004, 10, 12), "Secrétaire", 21000, "Comptabilité", a3, new List<Enfants>() { }));
            emp.Add(new Employes("Billot", "Jacques", new DateTime(2007, 02, 07), "Commercial", 25600, "Commercial", a1, new List<Enfants>() { enf3 }));

            //Console.WriteLine(enf1.ToString());
            // Nombre d'employes dans l'entreprise
            //Console.WriteLine("\nLe nombre d'employés est de : " + emp.Count+"\n");
            Console.WriteLine("\n Le nombre d'employés est de : " + Employes.Effectif() + "\n");


            // Virement des Primes
            DateTime moment = DateTime.Today;
            DateTime DateVirement = new DateTime(moment.Year, 11, 8);
            if (moment >= DateVirement)
            {
                foreach (var item in emp)
                {
                    Console.WriteLine(" L'ordre de transfert a bien ete transmis à la banque pour la somme de " + item.CalculPrime() + " Euros.");

                }
            }
            else
            {
                Console.WriteLine(" L'ordre de virement n'a pas été transmis");
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
            Console.WriteLine(" La Masse Salariale de l'entreprise est de " + masseSalariale + " Euros.");



        }
    }
}
