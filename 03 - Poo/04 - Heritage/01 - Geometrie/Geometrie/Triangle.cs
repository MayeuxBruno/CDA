using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    class Triangle
    {
        public double BBase { get; set; }
        public double Hauteur { get; set; }

        public Triangle(double bBase, double hauteur)
        {
            this.BBase = bBase;
            this.Hauteur = hauteur;
        }

        public override string ToString()
        {
            return "\n Base : "+this.BBase+"\n Hauteur : "+this.Hauteur+"\n Perimètre : "+this.Perimetre()+
                   "\n Aire : "+this.Aire();
        }
        public virtual double Perimetre()
        {
            return this.Hauteur + this.BBase + Math.Sqrt(Math.Pow(this.Hauteur,2)+Math.Pow(this.BBase,2));
        }

        public double Aire()
        {
            return (this.BBase * this.Hauteur) / 2;
        }
    }
    

}
