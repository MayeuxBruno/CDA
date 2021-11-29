using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TablesRelation.Data.Models;

namespace TablesRelation.Data.Dto
{
    public class TypesproduitDTO
    {
        public string LibelleTypeProduit { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}
