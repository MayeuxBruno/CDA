using System;

namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Voitures v1 = new Voitures("Citroen","C4");
            v1.NbKilometres = 10000;
            Voitures v2 = new Voitures("Renault", "Kadjar");
            v2.Couleur = "Rouge";
            Console.WriteLine(v1.ToString());
            Console.WriteLine(v2.ToString());
            v1.Rouler(5000);
            Console.WriteLine(v1.ToString());*/

            char choix;
            Clients c1= new Clients("0212121", "Duarand", "Toto","0695128935");
            Clients c2 = new Clients("5698785", "Dupont", "Jacques", "0589654120");
            Clients c3 = new Clients("9512326", "Morin", "Serge", "0201569878");
            Comptes Cpt1 = new Comptes(2000, c1);
            Comptes Cpt2 = new Comptes(200, c2);
            Comptes Cpt3 = new Comptes(10000, c3);
            /*Console.WriteLine(Cpt1.ToString());
            Console.WriteLine(Cpt2.ToString());
            Cpt1.Crediter(100, Cpt2);
            Console.WriteLine(Cpt1.ToString());
            Console.WriteLine(Cpt2.ToString());
            */
            string compt;
            Console.Write("Entre votre numéro de compte ");
            compt = "Cpt" + Console.ReadLine();

            do
            {
                Console.Write    ("\n************************" +
                                  "\n 1 - Afficher les Infos du compte"+
                                  "\n 2 - Effectuer un Dépot " +
                                  "\n 3 - Effectuer un retrait" +
                                  "\n 4 - Effectuer un retrait d'un autre compte" +
                                  "\n 5 - Effectuer un dépot sur un autre compte" +
                                  "\n 6 - Afficher le nombre de compte créés" +
                                  "\n Q - Quitter"+
                                  "\n\nQuelle Action Souhaitez vous executer ? ");

                choix = (Convert.ToChar(Console.ReadLine().ToUpper()));
                switch (choix)
                {
                    case '1':
                        Console.WriteLine(compt.ToString());
                        break;
                    case '2':
                        break;
                    case '3':
                        break;
                    case '4':
                        break;
                    case '6':
                        Console.Write("Nombre de Compte crés : " + Comptes.NbComptes()+"\n");
                        break;
                    case 'Q':
                        break;
                    default:
                        Console.Write("Choix Inconnu");
                        break;
                }
            } while (choix != 'Q');
        }
    }
}
