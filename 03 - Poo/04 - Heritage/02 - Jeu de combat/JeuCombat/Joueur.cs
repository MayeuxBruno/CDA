using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuCombat
{
    class Joueur
    {
        public int PtsVie { get; private set; } = 50;

        public Joueur()
        {
           
        }

        public bool EstVivant()
        {
            if (this.PtsVie > 0) return true;
            return false;
        }

        public bool Attaque()
        {
            int lancerJoueur = De.LancerDe();
            int lancerMonstre = De.LancerDe();
            Console.WriteLine("Mon Heros attaque : " + lancerJoueur + " le Monstre : " + lancerMonstre);
            if (lancerJoueur >= lancerMonstre)
            {
                this.PtsVie += 1;
                return true;
            }
            return false;
        }

        public bool SubitDegats(int degats)
        {
            int bouclier = De.LancerDe();
            Console.WriteLine("***              bouclier " + bouclier);
            if (bouclier > 2)
            {
                this.PtsVie -= degats;
                return false;
            }
            return true;
        }



    }
}
