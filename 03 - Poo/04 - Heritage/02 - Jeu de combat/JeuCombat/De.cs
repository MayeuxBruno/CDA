using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuCombat
{
    class De
    {
        public De()
        {

        }
        public static int LancerDe()
        {
            Random aleatoire = new Random();
            return aleatoire.Next(1, 7);
        }
    }
}
