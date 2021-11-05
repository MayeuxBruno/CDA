using System;

namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            Voitures v1 = new Voitures("Citroen","C4");
            v1.NbKilometres = 10000;
            Voitures v2 = new Voitures("Renault", "Kadjar");
            v2.Couleur = "Rouge";
            Console.WriteLine(v1.ToString());
            Console.WriteLine(v2.ToString());
            v1.Rouler(5000);
            Console.WriteLine(v1.ToString());
        }
    }
}
