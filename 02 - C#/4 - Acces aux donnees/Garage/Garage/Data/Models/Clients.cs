using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Garage.Data.Models
{
    public partial class Client
    {
        [Key]
        public int IdClient { get; set; }
        public string NomClient { get; set; }
        public string PrenomClient { get; set; }
        public string AdresseClient { get; set; }
        public string CpClient { get; set; }
        public string VilleClient { get; set; }
    }
}
