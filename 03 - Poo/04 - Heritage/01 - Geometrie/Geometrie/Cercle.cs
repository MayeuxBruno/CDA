using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    class Cercle
    {
        public double Diametre { get; set; }

        public Cercle(double diametre)
        {
            this.Diametre = diametre;
        }

        public override string ToString()
        {
            return "\n Diamètre : " + this.Diametre + "\n Périmètre : " + this.Perimetre() + "\n Aire : " + this.Aire();
        }

        public double Perimetre()
        {
            return this.Diametre*Math.PI;
        }

        public double Aire()
        {
            return Math.Pow(this.Diametre, 2) * Math.PI;
        }
    }
}
