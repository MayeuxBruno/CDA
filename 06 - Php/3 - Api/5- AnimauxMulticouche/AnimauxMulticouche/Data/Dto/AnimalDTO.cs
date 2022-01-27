using AnimauxMulticouche.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimauxMulticouche.Data.Dto
{
    public class AnimalDTO
    {
        public int IdAnimal { get; set; }
        public string NomAnimal { get; set; }
        public int IdRegimeAlimentaire { get; set; }
        public int IdHabitat { get; set; }

        public virtual HabitatDTO SonHabitat { get; set; }
        public virtual RegimeAlimentaireDTO SonRegimeAlimentaire { get; set; }
    }
}
