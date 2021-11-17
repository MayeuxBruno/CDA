using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuCombat
{
    class MonstreFacile
    {
        public bool EstVivant { get; set; } = true;

        public MonstreFacile()
        {

        }

        public virtual int Attaque() 
        {
            int lancerJoueur = De.LancerDe();
            int lancerMonstre = De.LancerDe();
            Console.WriteLine("Le Monstre attaque : " + lancerJoueur + " mon Heros : " + lancerMonstre);
            if (lancerMonstre > lancerJoueur) return 10;
            return 0;
        }
    }
}
