using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    class Parallelepipede : Rectangle
    {
        public double Hauteur { get; set; }

        public Parallelepipede(double longueur, double largeur,double hauteur)
            :base(longueur,largeur)
        {
            this.Hauteur = hauteur;
        }

        public override double Perimetre()
        {
            return 2*base.Perimetre()+4*this.Hauteur;
        }

        public double Volume()
        {
            return base.Aire() * this.Hauteur;
        }

        public override string ToString()
        {
            return "\n Périmètre : " + this.Perimetre() + "\n Volume : " + this.Volume() ;
        }

       
    }
}
