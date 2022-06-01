using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_gnosys.Models
{
    public class Client
    {
        public int Id { get; set; }

        public string Genre { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public string Email { get; set; }

        public string Fonction { get; set; }

        public string Adresse { get; set; }

        public string Informations { get; set; }

        public string SiteInternet { get; set; }

        public bool IsParticulier { get; set; }

        public string DateCreation { get; set; }

        public string DateModification { get; set; }

        public string Ville { get; set; }

        public string CodePostal { get; set; }

        public string NumerosTelephone { get; set; }

        public string ComplementsAdresse { get; set; }

    }
}
