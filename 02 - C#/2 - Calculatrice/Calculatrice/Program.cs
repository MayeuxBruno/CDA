using System;

namespace Calculatrice
{
    class Program
    {
            public static int DemanderEntierPositif(string texte)
            {
                int valeur;
                bool isOk;
                do
                {
                    Console.Write(texte);
                    isOk = int.TryParse(Console.ReadLine(), out valeur);
                } while (!isOk || valeur < 0);
                return valeur;
            }

            public static double DemanderDouble(string texte)
            {
                double valeur;
                bool isOk;
                do
                {
                    Console.Write(texte);
                    isOk = double.TryParse(Console.ReadLine(), out valeur);
                } while (!isOk);
                return valeur;
            }

            public static double DemanderDoubleNonNul(string texte)
            {
                double valeur;
                bool isOk;
                do
                {
                    Console.Write(texte);
                    isOk = double.TryParse(Console.ReadLine(), out valeur);
                } while (!isOk || valeur != 0);
                return valeur;
            }

            public static char DemanderOperateur(string texte)
            {
                char operateur;
                bool isOk;
                bool condition;
                do
                {
                    Console.Write(texte);
                    isOk = char.TryParse(Console.ReadLine(), out operateur);
                    condition= !isOk || (operateur != '+' && operateur != '-' && operateur != '*' && operateur != '/' && operateur != '$' && operateur != '!' && operateur != 'v' && operateur != '=')
                    if (condition) Console.WriteLine("Opérateur inconnu");
                } while (condition);
                return char.ToLower(operateur);
            }

            static double Calcul(double valeur, char operateur)
            {
                double resultat = 1;
                switch (operateur)
                {
                    case '!':
                        if (valeur >= 0)
                        {
                            for (int i = 1; i <= valeur; i++)
                            {
                                resultat *= i;
                            }
                        }
                        else
                        {
                            Console.WriteLine(" Impossible de faire la factorielle d'une valeur négative ");
                            resultat = valeur;
                        }
                        break;
                    case 'v':
                        if (valeur >= 0)
                        {
                            resultat = Math.Sqrt(valeur);
                        }
                        else
                        {
                            Console.WriteLine(" Impossible de faire la racine carré d'une valeur négative ");
                            resultat = valeur;
                        }
                        break;
                }
                return resultat;
            }

            static double CalculSimple(double valeur1, double valeur2, char operateur)
            {
                double resultat = 0;
                switch (operateur)
                {
                    case '-':
                        resultat = valeur1 - valeur2;
                        break;
                    case '+':
                        resultat = valeur1 + valeur2;
                        break;
                    case '*':
                        resultat = valeur1 * valeur2;
                        break;
                    case '/':
                        resultat = valeur1 / valeur2;
                        break;
                    case '$':
                        resultat = Math.Pow(valeur1, valeur2);
                        break;
                }
                return resultat;
            }
            static void Main(string[] args)
        {
              
            double valeur1, valeur2;
            char operateur;
            valeur1 = DemanderDouble("Saisissez la première valeur : ");
            do
            {
                operateur = DemanderOperateur("Saisissez l'opérateur + - * / $ ! v");
                if (operateur != '=')
                {
                    switch (operateur)
                    {
                        case '-':
                        case '+':
                        case '*':
                            valeur2 = DemanderDouble("Saisissez la deuxième valeur : ");
                            valeur1 = CalculSimple(valeur1, valeur2, operateur);
                            break;
                        case '/':
                            valeur2 = DemanderDoubleNonNul("Saisissez le diviseur : ");
                            valeur1 = CalculSimple(valeur1, valeur2, operateur);
                            break;
                        case '$':
                            valeur2 = DemanderEntierPositif("Saisissez l'exposant : ");
                            valeur1 = CalculSimple(valeur1, valeur2, operateur);
                            break;
                        case 'v':
                        case '!':
                            valeur1 = Calcul(valeur1, operateur);
                            break;
                    }
                    Console.WriteLine(" = " + valeur1);
                }
            } while (operateur != '=');
            Console.WriteLine("Le Résultat est " + valeur1);
            
        }
    }
}
