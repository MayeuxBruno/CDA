using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    class Pyramide:Triangle
    {
        public double Profondeur { get; set; }

        public Pyramide(double bbase, double hauteur,double profondeur)
            :base(bbase,hauteur)
        {
            Profondeur = profondeur;
        }

        public override double Perimetre()
        {
            return 2 * base.Perimetre() + 3 * this.Profondeur;
        }

        public double Volume()
        {
            return base.Aire() * this.Profondeur;
        }
        public override string ToString()
        {
            return "\n Périmètre : " + this.Perimetre() + "\n Volume : " + this.Volume();

        }
    }
}
