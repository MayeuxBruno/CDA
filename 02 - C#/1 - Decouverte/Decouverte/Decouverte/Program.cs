using System;

namespace Decouverte
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            /* Exercice 1 
            string chaine1;
            Console.WriteLine("Entrez la premiere chaine : ");
            chaine1 = Console.ReadLine();
            Console.WriteLine("La chaine saisie est : "+chaine1);
            Console.ReadLine();*/

            /* Exercice 2 
            int entier;
            Console.WriteLine("Entrez un entier : ");
            entier = Int32.Parse(Console.ReadLine());
            Console.WriteLine("L'entier saisie est : " + entier);
            Console.ReadLine();*/

            /* Exercice 3
            int entier1;
            int entier2;
            Console.WriteLine("Entrez le premier entier : ");
            entier1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Entrez le deuxième entier : ");
            entier2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("La somme des deux entiers est : " + (entier1 + entier2));
            Console.WriteLine("Le quotient des deux entiers est : " + (entier1 / entier2));
            Console.ReadLine();*/

            /* Exercice 4 
            float nb;
            Console.WriteLine("Entrez un nombre décimal : ");
            nb = float.Parse(Console.ReadLine());
            Console.WriteLine("Le nombre saisi est : "+nb);
            Console.ReadLine();*/

            /*Exercice 5
            float nb1;
            float nb2;
            float nb3;
            Console.WriteLine("Entrez un nombre décimal : ");
            nb1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Entrez un nombre décimal : ");
            nb2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Entrez un nombre décimal : ");
            nb3 = float.Parse(Console.ReadLine());
            Console.WriteLine("La moyenne des 3 valeurs est " + (nb1 + nb2 + nb3) / 3);
            Console.ReadLine();*/

            /* Exerercice 6
            Console.WriteLine("Entrez la longeur du rectangle : ");
            float longueur = float.Parse(Console.ReadLine());
            Console.WriteLine("Entrez la largeur du rectangle : ");
            float largeur = float.Parse(Console.ReadLine());
            Console.WriteLine("La surface du rectangle est : " + ((2 * longueur + 2 * largeur)));
            Console.ReadLine();*/

            /*Exercice 8*/
            char c;
            Console.WriteLine("Entrez un caractere : ");
            c= Convert.ToChar(Console.ReadLine().ToUpper());
            Console.WriteLine("Le caractere saisi est : " +c);
        }
    }
    
}
