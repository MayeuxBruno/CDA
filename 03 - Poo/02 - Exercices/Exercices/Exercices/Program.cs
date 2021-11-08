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

            List<Employes>emp = new List<Employes> ();
            emp.Add(new Employes("Dupont", "Jordan", new DateTime(1986, 12, 17), "Ouvrier", 17000, "Menuiserie"));
            emp.Add(new Employes("Dupont", "Céline", new DateTime(2007, 05, 02), "Secrétaire", 27000, "Direction"));
            emp.Add(new Employes("Morin", "Bernard", new DateTime(2001, 02, 02), "Comptable", 27500, "Comptabilité"));
            emp.Add(new Employes("Dut", "Cécile", new DateTime(2004, 10, 12), "Secrétaire", 21000, "Comptabilité"));
            emp.Add(new Employes("Billot", "Jacques", new DateTime(2007, 02, 07), "Commercial", 25600, "Commercial"));
            Console.Write("\nLe nombre d'employés est de : " + emp.Count+"\n");
            emp.Sort(Employes.CompareByName);
            foreach (Employes item in emp)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
