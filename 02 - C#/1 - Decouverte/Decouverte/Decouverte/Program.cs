using System;

namespace Decouverte
{
    using System.Text;
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
            if (int.TryParse(xHg, out xIHg) && int.TryParse(yHg, out yIHg) && int.TryParse(xBd, out xIBd) && int.TryParse(yBd, out yIBd)
                && ((xIBd>xIHg)&&(yIHg>yIBd))
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

            if (int.TryParse(xHg, out xIHg) && int.TryParse(yHg, out yIHg) && int.TryParse(xBd, out xIBd) && int.TryParse(yBd, out yIBd) && int.TryParse(vx, out vIx)&& int.TryParse(vy, out vIy))
            {  
                if((xIBd>xIHg)&&(yIHg>yIBd))
                {
                    correct = ((vIx >= xIHg && vIx <= xIBd) && (vIy >= yIHg && vIy <= yIBd) ? true : false);
                    Console.WriteLine("Le point " + (correct ? "fait" : "ne fait pas") + " parti du rectangle");
                }
                else
                {
                    Console.WriteLine("Le rectangle n'est pas correcte");
                }
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
            }

            int valeur;
            Console.Write("Entrez une valeur entière positive :");
            valeur = Convert.ToInt32(Console.ReadLine());
            for (int i = valeur;i>= 0;i--)
            {
                Console.Write(i + (i > 0 ? ", " : ""));
            }

            int valeur;
            Console.Write("Entrez une valeur entière positive :");
            valeur = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write(valeur + (valeur > 0 ? ", " : ""));
                valeur--;
            } while (valeur >= 0);*/


            /* Exercice 4.5
            int valeur;
            int fact = 1;
            Console.Write("Entrez une valeur entière positive : ");
            valeur = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i<=valeur;i++)
            {
                fact *= i;
            }
            Console.WriteLine("La factorielle de " + valeur + " est " + fact);

            int valeur;
            int fact = 1;
            int i=1;
            Console.Write("Entrez une valeur entière positive : ");
            valeur = Convert.ToInt32(Console.ReadLine());
            while(i<=valeur)
            {
                fact *= i;
                i++;
            }
            Console.WriteLine("La factorielle de " + valeur + " est " + fact);

            int valeur;
            int fact = 1;
            int i = 1;
            Console.Write("Entrez une valeur entière positive : ");
            valeur = Convert.ToInt32(Console.ReadLine());
            do
            {
                fact *= i;
                i++;
            } while (i <= valeur) ;
                Console.WriteLine("La factorielle de " + valeur + " est " + fact);*/

            /* Exercice 4.6 
            int valeur;
            Console.Write("Entrez une valeur entière positive : ");
            valeur = Convert.ToInt32(Console.ReadLine());
            for (int i=0;i<=10;i++)
            {
                Console.WriteLine(i + " x " + valeur + " = " + (i * valeur));
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
                    //Console.Write(i + " x " + j + " = " + (i * j)+ (j < 10 ? "\t" : "\n"));
                    Console.Write((i * j)+ (j < 10 ? "\t" : "\n"));
                }
            }*/


            /* Exercice 4.8
            int b, n,res;
            Console.Write("Entrez une valeur entière positive :");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entrez l'exposant :");
            n= Convert.ToInt32(Console.ReadLine());
            if (n>0)
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

            /*Exercice 4-10 
            double a, b;
            char op;
            Console.WriteLine("valeur a : ");
            a = double.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("opérateur de calcul");
                op = char.Parse(Console.ReadLine());
                if (op != '=')
                {
                    Console.WriteLine("valeur b : ");
                    b = double.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case '-':
                            a = a - b;
                            break;
                        case '+':
                            a = a + b;
                            break;
                        case '*':
                            a = a * b;
                            break;
                        case '/':
                            if (b == 0)
                            {
                                Console.WriteLine("Division impossible par 0");
                            }
                            else
                            {
                                a = a / b;
                            }
                            break;
                        default:
                            Console.WriteLine("Operateur invalide");
                            break;
                    }
                }
            } while(op != '=');
            Console.WriteLine("Le Résultat est " + a);

            /*Exercice 4-11 
            double a, b;
            char op;
            Console.WriteLine("valeur a : ");
            a = double.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("opérateur de calcul");
                op = char.Parse(Console.ReadLine());
                if (op != '=')
                {
                    Console.WriteLine("valeur b : ");
                    b = double.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case '-':
                            a = a - b;
                            break;
                        case '+':
                            a = a + b;
                            break;
                        case '*':
                            a = a * b;
                            break;
                        case '/':
                            if (b == 0)
                            {
                                Console.WriteLine("Division impossible par 0");
                            }
                            else
                            {
                                a = a / b;
                            }
                            break;
                        case '$':
                            if (b > 0)
                            {
                                for (double i = b; i > 1; i--)
                                {
                                    a *= b;
                                }
                            }
                            else
                            {
                                Console.WriteLine("La valeur n'est pas positive...");
                            }
                            break;
                        default:
                            Console.WriteLine("Operateur invalide");
                            break;
                    }
                }
            } while (op != '=');
            Console.WriteLine("Le Résultat est " + a);*/

            /*Exercice 4-12 
            double a, b;
            double fact = 1;
            char op;
            Console.WriteLine("valeur a : ");
            a = double.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("opérateur de calcul ( + - * / $ r ! = )");
                op = char.Parse(Console.ReadLine());
                if (op != '=')
                {
                    if (op == 'r' || op == '!')
                    {
                        switch(op)
                        {
                            case 'r':
                                a = Math.Sqrt(a);
                                break;
                            case '!':
                                for (int i = 1; i <= a; i++)
                                {
                                    fact *= i;
                                }
                                a = fact;
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("valeur b : ");
                        b = double.Parse(Console.ReadLine());
                        switch (op)
                        {
                            case '-':
                                a = a - b;
                                break;
                            case '+':
                                a = a + b;
                                break;
                            case '*':
                                a = a * b;
                                break;
                            case '/':
                                if (b == 0)
                                {
                                    Console.WriteLine("Division impossible par 0");
                                }
                                else
                                {
                                    a = a / b;
                                }
                                break;
                            case '$':
                                if (b > 0)
                                {
                                    for (double i = b; i > 1; i--)
                                    {
                                        a *= a;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("La valeur n'est pas positive...");
                                }
                                break;
                            default:
                                Console.WriteLine("Operateur invalide");
                                break;
                        }
                    }
                }
            } while (op != '=');
            Console.WriteLine("Le Résultat est " + a);*/


            /* Exercice 5.1 
            string valeur = "Les framboises sont perchées dur le tabouret de mon grand père";
            for(int i=0;i<(valeur.Length);i++)
                {
                    Console.WriteLine(valeur[i]);
                }*/


            /* Exercice 5.2 
            string t;
            string tt = "";
            int i, j;
            Console.Write("Saisissez une chaine de caractères : ");
            t = Console.ReadLine();
            Console.Write("Saisissez l'index de début : ");
            i = int.Parse(Console.ReadLine());
            Console.Write("Saisissez l'index de fin : ");
            j = int.Parse(Console.ReadLine());
            for(int k = i; k <= j; k++) 
            {
                tt =tt +  t[k];
            }
            Console.WriteLine(tt);*/

            /* Exercice 5.3 
            string t;
            string tt = "" ;
            int i, j;
            Console.Write("Saisissez une chaine de caractères : ");
            t = Console.ReadLine();
            Console.Write("Saisissez l'index de début : ");
            i = int.Parse(Console.ReadLine());
            Console.Write("Saisissez l'index de fin : ");
            j = int.Parse(Console.ReadLine());
            tt = tt.Insert(0, t.Substring(i, j));
            Console.WriteLine(t);
            Console.WriteLine(tt);*/

            /* Exercice 5.4 
            string t, tt;
            char a, b;
            Console.Write("Saisissez une chaine de caractères : ");
            t = Console.ReadLine();
            Console.Write("Saisissez le caractère à remplacer : ");
            a =Convert.ToChar(Console.ReadLine());
            Console.Write("Saisissez le caractere de remplacement : ");
            b = Convert.ToChar(Console.ReadLine());
            tt = t.Replace(a,b);
            Console.WriteLine(t);
            Console.WriteLine(tt);*/

            /* Exercice 5.5 
            StringBuilder chaine;
            char a, b;
            Console.Write("Saisissez une chaine de caractères : ");
            chaine== new StringBuilder((Console.ReadLine()));
            Console.WriteLine(chaine);
            Console.Write("Saisissez le caractère à remplacer : ");
            a = Convert.ToChar(Console.ReadLine());
            Console.Write("Saisissez le caractere de remplacement : ");
            b = Convert.ToChar(Console.ReadLine());
            for (int i=0; i<chaine.Length;i++)
            {
                if(chaine[i]==a)
                {
                    chaine[i] = b;
                }
            }
            Console.WriteLine(chaine);*/

            /* Exercice 5.6 
            string fichier;
            int index,index1;
            Console.Write("Saisissez un nom de fichier : ");
            fichier = Console.ReadLine();
            index = fichier.LastIndexOf('.');
            index1 = fichier.IndexOf('.');
            Console.WriteLine("Le nom du fichier est : "+fichier.Substring(0,index1));
            Console.WriteLine("L'extension du fichier est : "+fichier.Substring(index));*/

            /* Exercice 5.7 
            string expression;
            int i=0;
            int cpt = 0;
            Console.WriteLine("Entrez une expression : ");
            expression = Console.ReadLine();
            do
            {
                if (expression[i] == '(') cpt++;
                else if (expression[i] == ')') cpt--;
                i++;
            }while(i < expression.Length && cpt>0);
            if(cpt==0)
            {
                Console.WriteLine("l'expression est correcte");
            }
            else
            {
                Console.WriteLine("l'expression n'est pas correcte");
            }*/


            /* Exercice 6.1*/
            // aJkr bKlS

            /* Exercice 6.2 */

            /* Exercice 6.3*/

            /* Exercice 6.4 
            int[] T = new int[] {1,2,3,4,5,6,7,8,9,10};
            foreach (int val in T)
            {
                Console.WriteLine(val);
            }*/

            /* Exercice 6.5 
            int[] T = new int[10];
            for (int i=0;i<10;i++)
            {
                T[i] = i+1;
            }
            foreach (int val in T)
            {
                Console.WriteLine(val);
            }*/

            /* Exercice 6.6
            int[] T = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int somme=0;
            foreach (int val in T)
            {
                somme+=val;
            }
            Console.WriteLine(somme);*/

            /* Exercice 6.7 
            int[] T = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int recherche;
            int i = 0;
            bool trouve = false;
            Console.Write("Entrez la valeur à rechercher : ");
            recherche = Convert.ToInt32(Console.ReadLine());
            while (i<T.Length && !trouve)
            {
                if (T[i] == recherche) trouve = true;
                i++;
            }
            Console.WriteLine("La valeur " + recherche +(trouve? " se trouve dans le tableau": " ne se trouve pas dans le tableau"));*/


            /* Exercice 6.8 
           int[] t = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
           int[] t = new int[10];
           int j = t.Length - 1;
           for (int i=0;i<t.Length;i++)
           {
               u[i] = t[j];
               j++;
               if (j >= t.Length) j = 0;
           }
           foreach (int val in u)
           {
               Console.Write(val+" ");
           }*/

            /* Exercice 6.9
            int[] t = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int j = t.Length - 1;
            int temp = t[j];
            for (int i=j;i>0;i--)
            {
                t[i] = t[i - 1];
            }
            t[0] = temp;
            foreach (int val in t)
            {
                Console.Write(val + " ");
            }*/

            /* Exercice 6.10 
            int[] t = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11};
            int j = t.Length - 1;
            int temp;
            for (int i=0;i<j;i++)
            {
                temp = t[i];
                t[i] = t[j];
                t[j] = temp;
                j--;
            }
            foreach (int val in t)
            {
                Console.Write(val + " ");
            }*/

            /* Exercice 6.11 
            int[] t = new int[10];
            ArrayResize(ref t, t.Length + 10);
            for (int i=0;i<t.Length;i++)
            {
                t[i] = i*i%17;
            }
            foreach (int val in t)
            {
                Console.Write(val + " ");
            }*/

            /* Exercice 6.12 
            int[] t = new int[] { 70, 2, 3, 4, 5, 6, 90, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 1 };
            int max, min;
            max = min = t[0];
            for (int i=1;i<t.Length;i++)
            {
                if (t[i] > max)
                {
                    max = t[i];
                }
                else if (t[i]<min)
                {
                    min = t[i];
                }
            }
            Console.WriteLine("La valeur Maxi est " + max + " et la valeur Mini est "+min);*/

            /* Exercice 6.13 
            int[] t = new int[] { 1, 2, 3, 4, 5, 6, 90, 1, 9, 10, 11, 12, 1, 14, 15, 16, 17, 18, 19, 1 };
            int valeur;
            Console.Write("Entrez une valeur à rechercher");
            valeur = Convert.ToInt32(Console.ReadLine());
            for (int i=0;i<t.Length;i++)
            {
                if (t[i]==valeur)
                {
                    Console.Write(i + " ");
                }
            }*/

            /* Exercice 6.14 */
            int[] t = new int[] { 1, 2, 3, 4, 5, 6, 90, 1, 9, 10, 11, 12, 1, 14, 15, 16, 17, 18, 19, 1 };
            int[] q = new int[0];
            int valeur;
            Console.Write("Entrez une valeur à rechercher : ");
            valeur = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == valeur)
                {
                    Array.Resize(ref q, q.Length + 1);
                    q[q.Length-1]=i ;
                }
            }
            if (q.Length != 0)
            {
                Console.Write("La valeur " + valeur + " a été trouvée aux indices suivants : ");
                foreach (int val in q)
                {
                    Console.Write(val + " ");
                }
            }
            else
            {
                Console.Write("La valeur "+valeur+" n'a pas été trouvée");
            }

            /* Exercice 6.15
            double[] pieces = new double[] {0.5,0.1,0.1,0.05,0.02,0.01};
            int[] nbPieces = new int[6];
            double somme;
            Console.Write("Veuillez saisir la somme : ");
            somme = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(somme);
            if (somme == 0.2) Console.WriteLine("ok");
            while (somme > 0) 
            {
                if(somme%0.2==0)
                {
                    Console.WriteLine("1 pièce ");
                    somme = somme - 0.2;
                }
                
            }*/


        }

    }
}
