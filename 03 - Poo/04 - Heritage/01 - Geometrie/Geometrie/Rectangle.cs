using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    class Rectangle
    {
        public double Longueur { get; set; }
        public double Largeur { get; set; }

        public Rectangle(double longueur, double largeur)
        {
            this.Longueur = longueur;
            this.Largeur = largeur;
        }

        public override string ToString()
        {
            return "\n Longueur : " + this.Longueur + "\n Largeur : " + this.Largeur + "\n Périmètre : " + this.Perimetre() +
                   "\n Aire : " + this.Aire() + ((this.EstCarre()) ? "\n Il s'agit d'un carre" : "\n Il ne s'agit pas d'un carre");
        }
        public virtual double Perimetre()
        {
            return (this.Longueur + this.Largeur) * 2; 
        }

        public virtual double Aire()
        {
            return this.Longueur * this.Largeur;
        }

        public bool EstCarre()
        {
            if (this.Longueur == this.Largeur) return true;
            return false;
        }
    }
}
