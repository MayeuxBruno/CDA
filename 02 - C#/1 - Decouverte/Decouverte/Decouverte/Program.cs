using System;

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
            Console.WriteLine("La surface du rectangle est : " + (longueur * largeur));*/

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
                    if(b!=0)
                    {
                        Console.WriteLine(a + " / " + b + " = " + (a / b));
                    }
                    else{
                        console.WriteLine("Division par 0 impossible");
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

            /* Exercice 3-10 
            string nomPiece = "";
            int piece,i,j,ii,jj;
            bool correct = false;
            Console.WriteLine("Quelle pièce souhaitez vous déplacer?" +
                               "\n*---------------------------*"+ 
                               "\n 0 = Cavalier" +
                               "\n 1 = Tour" +
                               "\n 2 = Fou" +
                               "\n 3 = Dame" +
                               "\n 4 = Roi"+
                               "\n*---------------------------*");
            piece = Convert.ToInt32(Console.ReadLine());
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
                case 0: // Cavalier
                    nomPiece = "Cavalier";
                    correct = ((Math.Abs(i - ii) == 2 && Math.Abs(j - jj) == 1 || Math.Abs(i - ii) == 1 && Math.Abs(j - jj) == 2) ? true : false);
                    break;

                case 1: // Tour
                    nomPiece = "Tour";
                    correct = ((i == ii || j == jj) ? true : false);
                    break;

                case 2: //Fou
                    nomPiece = "Fou";
                    correct = ((Math.Abs(i - ii) == Math.Abs(j - jj))?true:false);
                    break;

                case 3: // Dame
                    nomPiece = "Dame";
                    correct = (i == ii || j == jj || Math.Abs(i - ii) == Math.Abs(j - jj) ? true:false);
                    break;
                    

                case 4: //Roi
                    nomPiece = "Roi";
                    correct = ((Math.Abs(i - ii) < 2 && Math.Abs(j - jj) < 2) ? true:false);
                    break;         
            }
            Console.WriteLine("Déplacement "+((piece==1||piece==3)?"de la":"du")+" "+nomPiece+" de ( " + i + " , " + j + " ) vers ( " + ii + " , " + jj + " ) "+ (correct==true ? "est correcte":"n'est pas correcte"));
            */

            /* Exercice 3-11 
            int h,m,hh,mm,hr,mr;
            Console.WriteLine("Entrez l'heure de début : ");
            Console.Write("Heures de début : ");
            h = Convert.ToInt32(Console.ReadLine());
            Console.Write("Minutes de début : ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrez l'heure de fin : ");
            Console.Write("Heures de fin : ");
            hh = Convert.ToInt32(Console.ReadLine());
            Console.Write("Minutes de fin : ");
            mm = Convert.ToInt32(Console.ReadLine());
            hr = hh - h;
            if (hr >= 0)
            {
                mr = mm - m;
                if (mr < 0)
                {
                    mr = 60 - Math.Abs(mr);
                    hr--;
                }
                Console.WriteLine("La différence entre " + h + " H " + m + " Min et " + hh + " H " + mm + " Min, est de " + hr + " H " + mr + " Min ");
            }
            else
            {
                Console.WriteLine("L'heure de début doit se trouver avant l'heure de fin");
            }*/

            /* Exercice 3-12 
            int jour, mois, annee;
            Console.WriteLine("Veuillez saisir une date : ");
            Console.Write(" Jour : ");
            jour = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Mois : ");
            mois = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Année : ");
            annee = Convert.ToInt32(Console.ReadLine());
            jour++;
            if(mois==1||mois==3||mois==5||mois==8||mois==10||mois==12)
            {
                if(jour>31)
                {
                    if (mois == 12)
                    {
                        annee++;
                        jour = 1;
                        mois = 1;
                    }
                    else
                    {
                        jour = 1;
                        mois++;
                    }
                }
            }
            else if (mois==4||mois==6||mois==9||mois==11)
            {
                if (jour > 30)
                {
                    jour = 1;
                    mois++;
                }
            }
            else
            {
                if ((annee % 4 == 0) && (annee % 100 != 0))
                {
                    if (jour>29)
                    {
                        jour = 1;
                        mois++;
                    }
                }
                else
                {
                    if (jour>28)
                    {
                        jour = 1;
                        mois++;
                    }
                }
            }
            Console.WriteLine("La date suivante sera le " + jour + " " + mois + " " + annee);*/

            /*Exercice 3-12
            string a;
            string b;
            int ba;
            int bb;
            Console.WriteLine("Veuillez saisir un intervalle : ");
            Console.Write(" Borne A : ");
            a = Console.ReadLine();
            Console.Write(" Borne B : ");
            b = Console.ReadLine();
            if (int.TryParse(a, out ba) & int.TryParse(b, out bb))
            {
                if (ba > bb)
                {
                    Console.WriteLine("l'intervalle [ " + a + " , " + b + " ] n'est pas valide la borne B doit être supérieur à la borne A");
                }
            }
            */

            /*Exercice 3-14
            string a, b, v;
            int ba,bb,vv;
            bool correct = false;
            Console.WriteLine("Veuillez saisir un intervalle : ");
            Console.Write(" Borne A : ");
            a = Console.ReadLine();
            Console.Write(" Borne B : ");
            b = Console.ReadLine();
            Console.Write(" Valeur : ");
            v = Console.ReadLine();
            if (int.TryParse(a, out ba) & int.TryParse(b, out bb) & int.TryParse(v, out vv))
            {
                if (ba < bb)
                {
                    correct = ((ba <= vv && vv <= bb) ? true : false);
                    Console.WriteLine("La valeur " + v + " " + (correct ? "se trouve" : "ne se trouve pas") + " dans l'intervalle [ " + a + " , " + b + " ]");
                }
                else
                {
                    Console.WriteLine("l'intervalle [ " + a + " , " + b + " ] n'est pas valide la borne B doit être supérieur à la borne A");
                }
            }
            else{
                Console.WriteLine("Erreur de saisie");
            }

            /*Exercice 3-15 
            string xHg, yHg, xBd, yBd;
            int xIHg, yIHg, xIBd, yIBd;
            Console.WriteLine("Entrez les coordonnées du rectangle : ");
            Console.Write("X Haut Gauche : ");
            xHg = Console.ReadLine();
            Console.Write("Y Haut Gauche : ");
            yHg = Console.ReadLine();
            Console.Write("X Bas Droit : ");
            xBd = Console.ReadLine();
            Console.Write("Y Bas Droit : ");
            yBd = Console.ReadLine();
            if (int.TryParse(xHg, out xIHg) && int.TryParse(yHg, out yIHg) && int.TryParse(xBd, out xIBd) && int.TryParse(yBd, out yIBd))
            {
                Console.WriteLine("Saisie Correcte");
            }
            else
            {
                Console.WriteLine("Erreur de saisie");
            }*/

            /*Exercice 3-16 
            string xHg, yHg, xBd, yBd,vx,vy;
            int xIHg, yIHg, xIBd, yIBd,vIx,vIy;
            bool correct = false;
            Console.WriteLine("Entrez les coordonnées du rectangle : ");
            Console.Write("X Haut Gauche : ");
            xHg = Console.ReadLine();
            Console.Write("Y Haut Gauche : ");
            yHg = Console.ReadLine();
            Console.Write("X Bas Droit : ");
            xBd = Console.ReadLine();
            Console.Write("Y Bas Droit : ");
            yBd = Console.ReadLine();
            Console.WriteLine("Entrez les coordonnées du point : ");
            Console.Write("X : ");
            vx = Console.ReadLine();
            Console.Write("Y : ");
            vy = Console.ReadLine();
            if (int.TryParse(xHg, out xIHg) && int.TryParse(yHg, out yIHg) && int.TryParse(xBd, out xIBd) && int.TryParse(yBd, out yIBd)&& int.TryParse(vx, out vIx)&& int.TryParse(vy, out vIy))
            {
                correct = ((vIx >= xIHg && vIx <= xIBd) && (vIy >= yIHg && vIy <= yIBd) ? true : false);
                Console.WriteLine("Le point "+(correct?"fait":"ne fait pas")+" parti du rectangle");
            }
            else
            {
                Console.WriteLine("Erreur de saisie");
            }*/

            /* Exercice 4.1  (6,15)*/

            /* Exercice 4.2 */
            /* Exercice 4.3 */

            /* Exercice 4.4 
            int valeur;
            Console.Write("Entrez une valeur entière positive :");
            valeur = Convert.ToInt32(Console.ReadLine());
            while(valeur>=0)
            {
                Console.Write(valeur + (valeur > 0 ? ", " : ""));
                valeur--;
            }*/

            /* Exercice 4.5
            int n;
            int f=1;
            Console.Write("Entrez une valeur entière positive :");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                f *= i;
            }
            Console.WriteLine("La factorielle de " + n + " est " + f);*/


            /* Exercice 4.6
            int n;
            Console.Write("Quelle table souhaitez vous ?");
            n = Convert.ToInt32(Console.ReadLine());
            for (int j=1; j<=10;j++)
            {
                Console.Write("\t"+j + " X " + n + " = " + (j * n) + "\n");
            }*/


            /* Exercice 4.7
            for(int i=1;i<=10;i++)
            {
                for(int j=1;j<=10;j++)
                {
                    Console.Write(i + " x " + j + " = " + (i * j)+ (j < 10 ? "\t" : "\n"));
                }
            }*/


            /* Exercice 4.8
            int b, n,res;
            Console.Write("Entrez une valeur entière positive :");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entrez l'exposant :");
            n= Convert.ToInt32(Console.ReadLine());
            if (b>0)
            {
                res = b;
                while(n>1)
                {
                    res *= b;
                    n--;
                }
                Console.WriteLine("Le résultat est : "+res);
            }
            else
            {
                Console.WriteLine("La valeur n'est pas positive...");
            }*/

            /* Exercice 4.9 
            int n;
            Console.Write("Entrez une valeur entière positive :");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <n; j++)
                {
                    Console.Write(" X " + (j < n-1 ? "\t" : "\n"));
                }
            }*/

            /* Exercice 4.10 */
            int a;
            int b;
            string op;
            Console.Write("Entrez la première valeur : ");
            a = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write("Entrez l'opérateur ( + - * / $ = ) : ");
                op = Console.ReadLine();
                if (op != "=")
                {
                    Console.Write("Entrez la deuxième valeur : ");
                    b = Convert.ToInt32(Console.ReadLine());
                    switch (op)
                    {
                        case "+":
                            a += b;
                            break;

                        case "-":
                            a -= b;
                            break;

                        case "*":
                            a *= b;
                            break;

                        case "/":
                            if (b != 0)
                            {
                                a /= b;
                            }
                            else
                            {
                                Console.WriteLine("Division par 0 impossible");
                            }
                            break;
                        case "$":
                                                            
                            break;
                        default:
                            Console.WriteLine("Opérateur non valide");
                            break;
                    }
                    Console.WriteLine(a);
                }
            } while (op != "=");
            Console.WriteLine("Le resultat est : " + a);
        }
    }
}
