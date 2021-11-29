using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TablesRelation.Data.Models;

namespace TablesRelation.Data.Dto
{
    public class CategoryDTO
    {
        public int IdCategorie { get; set; }
        public string LibelleCategorie { get; set; }
        public int IdTypeProduit { get; set; }

        public virtual Typesproduit IdTypeProduitNavigation { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
    }
}
