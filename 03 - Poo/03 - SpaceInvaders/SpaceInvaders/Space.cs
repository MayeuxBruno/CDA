using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class Space
    {
        public int NbLignes { get; set; }
        public int NbColonnes { get; set; }
        public List<List<char>> Grille { get; set; } = new List<List<char>>();

        public Space(int nbLignes, int nbColonnes)
        {
            this.NbLignes = nbLignes;
            this.NbColonnes = nbColonnes;
            this.InitGrille();
        }
     
        // Initialisation de la grille 
        private void InitGrille()
        {
            for (int k = 0; k < this.NbColonnes; k++)
            {
                Grille.Add(new List<char>());
                Grille[0].Add('#');
            }
            for (int i = 1; i < this.NbLignes; i++)
            {
                Grille.Add(new List<char>());
                for (int j =0; j<this.NbColonnes;j++)
                {
                    Grille[i].Add(' ');
                }
            }
        }

        /// <summary>
        /// Modifie la grille avec le motif de l'invader
        /// </summary>
        /// <returns>void</returns>
        public void ModifGrille (Invader inv)
        {
            for (int k = 0; k < this.NbColonnes; k++)
            {
                Grille[0][k]=inv.Motif;
            }
        }

        /// <summary>
        /// Affichage de la grille de jeu
        /// </summary>
        /// <returns>void</returns>
        public override string ToString()
        {
            string aff = " ";
            for (int j = 1; j <= this.NbColonnes; j++)// Ligne du plateau
            {
                aff += "_";
            }
            aff += "\n";
            for (int i = 0; i < this.NbLignes; i++)
            {
                aff += "|";
                for (int j = 0; j < this.NbColonnes; j++)
                {
                    aff+=Convert.ToString(Grille[i][j]);
                }
                aff += "|\n";
            }
            aff += "|";
            for (int j = 0; j < this.NbColonnes; j++)// Affiche derniere Ligne
            {
                aff += "_";
            }
            aff += "|";
            return aff;
        }
    }
}
