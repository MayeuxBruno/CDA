using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuCombat
{
    class MonstreDifficile:MonstreFacile
    {
        public MonstreDifficile()
        {

        }

        public override int Attaque()
        {
            int degats = 0;
            int lancerJoueur = De.LancerDe();
            int lancerMonstre = De.LancerDe();
            Console.WriteLine("Le Monstre attaque : " + lancerJoueur + " mon Heros : " + lancerMonstre);
            if (lancerMonstre>lancerJoueur)
            {
                degats = 10;
                lancerMonstre = De.LancerDe();
                Console.WriteLine("***              sort magique " + lancerMonstre);
                if (lancerMonstre != 6) degats += (5 * lancerMonstre);
            }
            return degats;
        }
    }
}
