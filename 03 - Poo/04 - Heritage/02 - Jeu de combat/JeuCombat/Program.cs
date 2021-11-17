using System;

namespace JeuCombat
{
    class Program
    {
        static void Main(string[] args)
        {
            Joueur joueur = new Joueur();
            Random aleatoire = new Random();
            MonstreFacile monstre;
            do
            {
                /* Genère un Monstre */
                Console.ForegroundColor = ConsoleColor.Yellow;
                monstre = new MonstreFacile();
                Console.WriteLine("**************** Monstre Suivant ****************");
                if (aleatoire.Next(0, 2) == 0)
                {
                    monstre = new MonstreFacile();
                }
                else
                {
                    monstre = new MonstreDifficile();
                    Console.WriteLine("C'est un Monstre Difficile");
                }
                Console.ForegroundColor = ConsoleColor.White;

                do
                {
                    if (joueur.Attaque())
                    {
                        Console.WriteLine("***              héro gagne", Console.ForegroundColor = ConsoleColor.Green);
                        monstre.EstVivant = false;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        int degats = monstre.Attaque();
                        Console.ForegroundColor = ConsoleColor.White;
                        if (degats > 0)
                        {

                            if (!joueur.SubitDegats(degats))
                            {
                                Console.WriteLine("***              héro subit des degats " + degats + " Reste " + joueur.PtsVie, Console.ForegroundColor = ConsoleColor.Red);
                            }
                            else
                            {
                                Console.WriteLine("***              héro subit des degats 0 Reste " + joueur.PtsVie, Console.ForegroundColor = ConsoleColor.Red);

                            }
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                } while (monstre.EstVivant && joueur.EstVivant()) ;
             } while (joueur.EstVivant());
            Console.WriteLine("Dommage vous êtes morts.......");
        }
    }
}
