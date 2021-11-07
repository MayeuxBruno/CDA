using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    class Clients
    {
        public string Cin { get; set; }
        public string Nom { get; set; }
        public string prenom { get; set; }
        public string Tel { get; set; }

        public Clients(string NvCin, string NvNom, string NvPrenom, string NvTel)
        {
            this.Cin = NvCin;
            this.Nom = NvNom;
            this.prenom = NvPrenom;
            this.Tel = NvTel;
        }

        public Clients(string NvCin, string NvNom, string NvPrenom)
        {
            this.Cin = NvCin;
            this.Nom = NvNom;
            this.prenom = NvPrenom;
        }

        public string Afficher()
        {
            return "\n N° CIN : " + this.Cin +
                     "\n Nom :" + this.Nom +
                     "\n Prenom : " + this.prenom +
                     "\n Telephone: " + this.Tel;
        }

    }
}
