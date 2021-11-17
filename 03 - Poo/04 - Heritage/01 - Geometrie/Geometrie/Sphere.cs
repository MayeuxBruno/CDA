using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    class Sphere : Cercle
    {
        public Sphere(double diametre) : base(diametre)
        {
        }

        public double Volume()
        {
            return ((4 / 3) * Math.PI) * Math.Pow((this.Diametre / 2), 3);

        }

        public override string ToString()
        {
            return "\n Diametre : "+this.Diametre+"\n Volume : " + this.Volume();
        }
    }
}
