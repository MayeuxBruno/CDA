﻿using System;

namespace Decouverte
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            /* Exercice 1-1 
            string chaine1;
            Console.WriteLine("Entrez votre nom : ");
            chaine1 = Console.ReadLine();
            Console.WriteLine("La nom saisie est : "+chaine1);*/

            /* Exercice 1-2 
            int entier;
            Console.Write("Entrez un entier : ");
            entier = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("L'entier saisie est : " + entier);*/

            /* Exercice 1-3 
            int entier1;
            int entier2;
            Console.Write("Entrez le premier entier : ");
            entier1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entrez le deuxième entier : ");
            entier2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La somme des deux entiers est : " + (entier1 + entier2));
            Console.WriteLine("Le quotient des deux entiers est : " + (entier1 / entier2));*/

            /* Exercice 1-4 
            float nb;
            Console.WriteLine("Entrez un nombre décimal : ");
            nb = float.Parse(Console.ReadLine());
            Console.WriteLine("Le nombre saisi est : "+nb);*/

            /*Exercice 1-5
            float nb1;
            float nb2;
            float nb3;
            Console.Write("Entrez un nombre décimal : ");
            nb1 = float.Parse(Console.ReadLine());
            Console.Write("Entrez un nombre décimal : ");
            nb2 = float.Parse(Console.ReadLine());
            Console.Write("Entrez un nombre décimal : ");
            nb3 = float.Parse(Console.ReadLine());
            Console.WriteLine("La moyenne des 3 valeurs est " + (nb1 + nb2 + nb3) / 3);*/

            /* Exerercice 1-6
            float longueur;
            float largeur;
            Console.Write("Entrez la longeur du rectangle : ");
            longueur = float.Parse(Console.ReadLine());
            Console.Write("Entrez la largeur du rectangle : ");
            largeur = float.Parse(Console.ReadLine());
            Console.WriteLine("La surface du rectangle est : " + (2 * longueur + 2 * largeur));*/

            /* Exercice 1-7 
            char a='B';
            Console.WriteLine("Le code ascii de "+a+" est : " + (int)a);
            Console.ReadLine();*/

            /*Exercice 1-8
            char c;
            Console.WriteLine("Entrez un caractere : ");
            c= Convert.ToChar(Console.ReadLine().ToUpper());
            Console.WriteLine("Le caractere saisi est : " +c); */

            /*Exercice 2-1 
            char c;
            int ascii;
            Console.WriteLine("Entrez un caratère : ");
            c = Convert.ToChar(Console.ReadLine());
            ascii = (int)c;
            Console.WriteLine("le code ascii de "+c+" est "+ascii+" , le suivant est : " + (ascii+1));*/

            /* Exercices 2-2 
            char a = '0';
            char b = '1';
            char c = '2';
            char d = '3';
            char e = '4';
            char f = '5';
            char g = '6';
            char h = '7';
            char i = '8';
            char j = '9';
            Console.WriteLine("Les code ascii de 0,1,2,3,4,5,6,7,8,9 sont " + (int)a + "," + (int)b + "," + (int)c + "," + (int)d + "," + (int)e + "," + (int)f + "," + (int)g + "," + (int)h + "," + (int)i + "," + (int)j);*/

            /* Exercice 2-3 
            float M;
            float k;
            int nbCartons;
            Console.WriteLine("Entrez le poids dun carton : ");
            k = float.Parse(Console.ReadLine());
            Console.WriteLine("Entrez la masse maximale du camion : ");
            M = float.Parse(Console.ReadLine());
            nbCartons = (int)(M / k);
            Console.WriteLine("Vous pouvez charger "+nbCartons+" Cartons");*/

            /* Exercice 3-1
            int age;
            Console.Write("Entrez votre age : ");
            age = Convert.ToInt32(Console.ReadLine());
            if (age>17)
            {
                Console.WriteLine("Vous êtes Majeur");
            }
            else
            {
                Console.WriteLine("Vous êtes Mineur");
            }*/

            /*Exercice 3-2
            int valeur;
            Console.WriteLine("Entrez une valeur : ");
            valeur = Convert.ToInt32(Console.ReadLine());
            if(valeur<0)
            {
                valeur = -1 * valeur;
            }
            Console.WriteLine("La valeur absolue est " + valeur);*/

            /*Exercice 3-3
            int note;
            Console.WriteLine("Entrez une note : ");
            note = Convert.ToInt32(Console.ReadLine());
            if (note < 8)
            {
                Console.WriteLine("ajourné");
            }
            else if (note <= 10)
            {
                Console.WriteLine("Rattrapage");
            }
            else
            {
                Console.WriteLine("admis");
            }*/

            /* Exercice 3-4 
            float montant;
            float franchise;
            Console.WriteLine("Entrez le montant des dommages : ");
            montant = float.Parse(Console.ReadLine());
            franchise = (montant*10)/100;
            if(franchise>4000)
            {
                franchise=4000;
            }
            montant = montant - franchise;
            Console.WriteLine("Le montant à rembourser est de : " + montant + "\nLe montant de la franchise est de : " + franchise);*/

            /* Exercice 3-5 
            int a;
            int b;
            Console.Write("Entrez la première valeur : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entrez la deuxième valeur : ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("il n'y a pas de valaurs distinctes");
            }
            else
            {
                Console.WriteLine("Il y a 2 valeurs distinctes");
            }*/

            /* Exercice 3-6 
            int a;
            int b;
            int c;
            int min;
            Console.Write("Entrez la première valeur : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entrez la deuxième valeur : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entrez la troisième valeur : ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a<=b)
            {
                min = a;
            }
            else
            {
                min = b;
            }
            if(c<=min)
            {
                min = c;
            }
            Console.Write("La plus petite valeur est : " + min);*/

            /* Exercice 3-7 
            int a;
            int b;
            string op;
            Console.Write("Entrez la première valeur : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entrez la deuxième valeur : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entrez l'opérateur ( + - * / ) : ");
            op = Console.ReadLine();
            switch (op)
            {
                case "+" :
                    Console.WriteLine(a+" + "+b+" = "+(a+b));
                    break;

                case "-":
                    Console.WriteLine(a + " - " + b + " = " + (a - b));
                    break;

                case "*":
                    Console.WriteLine(a + " * " + b + " = " + (a * b));
                    break;

                case "/":
                    Console.WriteLine(a + " / " + b + " = " + (a / b));
                    break;
                default:
                    Console.WriteLine("Opérateur non valide");
                    break;
            }*/

            /* Exercice 3-8 
            int i;
            int j;
            Console.Write("Entrez la valeur de la ligne : ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entrez valeur de la colonne : ");
            j = Convert.ToInt32(Console.ReadLine());
            if(( i>0 && i<=8 ) && (j>0 && j<=8))
            {
               //if((i%2==0 && j%2==0)||(i%2!=0 && j%2!=0))
                if((i+j)%2==0)
                {
                    Console.WriteLine("La case est de couleur noire");
                }
                else
                {
                    Console.WriteLine("La case est de couleur blanche");
                }
            }
            else
            {
                Console.Write("Coordonnées Invalides");
            }*/

            /* Exercice 3-9
            int i;     // Coordonnée Ligne première case 
            int j;     // Coordonnée colonne première case 
            int ii;    // Coordonnée Ligne deuxième case
            int jj;    // Coordonnée Colonne Deuxième case
            Console.Write("Entrez la valeur de la ligne de la première case: ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entrez valeur de la colonne de la première case: ");
            j = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entrez la valeur de la ligne de la deuxième case: ");
            ii = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entrez valeur de la colonne de la deuxième case: ");
            jj = Convert.ToInt32(Console.ReadLine());
            if ((i > 0 && i <= 8) && (j > 0 && j <= 8)&& (ii > 0 && ii <= 8) && (jj > 0 && jj <= 8))  // Test si les coordonnées des 2 cases sont valides
            {
                if ((((ii==i+2)||(ii==i-2))&&((jj==j+1)||(jj==j-1)))||(((jj==j+2)||(jj==j-2)) && ((ii==i+1)||(ii==i-1))))
                {
                    Console.WriteLine("Déplacement Possible");
                }
                else
                {
                    Console.WriteLine("Déplacement impossible");
                }

            }
            else
            {
                Console.WriteLine("Coordonnées Invalides");
            }*/

            /* Exercice 3-10 */
            string piece;
            int i;
            int j;
            int ii;
            int jj;
            Console.WriteLine("Quelle pièce souhaitez vous déplacer?");
            Console.WriteLine("0 = Cavalier");
            Console.WriteLine("1 = Tour");
            Console.WriteLine("2 = Fou");
            Console.WriteLine("3 = Dame");
            Console.WriteLine("4 = Roi");
            piece = Console.ReadLine();
            Console.WriteLine("Coordonnées (i,j) de la position de depart : ");
            Console.Write("i= ");
            i=Convert.ToInt32(Console.ReadLine());
            Console.Write("j= ");
            j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Coordonnées (i',j') de la position d'arrivée : ");
            Console.Write("i'= ");
            ii = Convert.ToInt32(Console.ReadLine());
            Console.Write("j'= ");
            jj = Convert.ToInt32(Console.ReadLine());
            switch (piece)
            {
                case "0":
                    if ((((ii == i + 2) || (ii == i - 2)) && ((jj == j + 1) || (jj == j - 1))) || (((jj == j + 2) || (jj == j - 2)) && ((ii == i + 1) || (ii == i - 1))))
                    {
                        Console.WriteLine("Déplacement du cavalier de ("+i+" , "+j+") vers ("+ii+" , "+jj+") correct.");
                    }
                    else
                    {
                        Console.WriteLine("Déplacement du cavalier de (" + i + " , " + j + ") vers (" + ii + " , " + jj + ") n'est pas correct.");
                    }
                    break;

                case "1":
                    if((i==ii && Math.Abs(j-jj)>=1)|| (j == jj && Math.Abs(i - ii) >= 1))
                    {
                        Console.WriteLine("Déplacement de la Tour de (" + i + " , " + j + ") vers (" + ii + " , " + jj + ") correct.");
                    }
                    else
                    {
                        Console.WriteLine("Déplacement du la Tour de (" + i + " , " + j + ") vers (" + ii + " , " + jj + ") n'est pas correct.");
                    }
                    break;

                case "2":
                    break;

                case "3":
                    break;

                case "4":
                    break;
            }
        }
    }
    
}
