using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestionFichier
{
    class Program
    { 
      
        static void Main(string[] args)
        {
            string path = @"..*../../MonFichier.txt";
            string[] tableau = new string[10];
            string[] tableauRetour = new string[10];
            tableau = PrepareLeTableaAEnregistrer(tableau);
            AfficherTableau(tableau);
            EcrireFichier(tableau, path);
            tableauRetour = LireFichier(path);
            if(tableauRetour != null)
            {
                Console.WriteLine("\n Tableau Récupéré");
                AfficherTableau(tableauRetour);
            }
            Console.Read();
        }

        /// <summary>
        /// Remplit un tableau
        /// </summary>
        /// <param name="tab"></param>
        /// <returns>string[]</returns>
        static string[] PrepareLeTableaAEnregistrer(string[] tab)
        {
            for (int i = 0; i < 10; i++)
            {
                tab[i] = " nom " + (i + 1) + " infos " + i;
            }
            return tab;
        }

        /// <summary>
        /// Renvoi un tableau de chaine contenant les informations stockées dans le fichier
        /// </summary>
        /// <param name="path"></param>
        /// <returns>string[]</returns>
        static string[] LireFichier(string path)
        {
            string[] chaine = new string[10];
            try
            {
                chaine = File.ReadAllLines(path);
            }
            catch (Exception e)
            {
                Console.WriteLine("Une exception s'est produite : " + e.Message);
                Console.WriteLine("Indiquer le path :");
                chaine = LireFichier(Console.ReadLine());
            }
            return chaine;
        }

        static void EcrireFichier(string[] chaine,string path)
        {
            File.WriteAllLines(path, chaine);
        }

        static void AfficherTableau(string[] tab)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(tab[i]);
            }
        }
    }
}
