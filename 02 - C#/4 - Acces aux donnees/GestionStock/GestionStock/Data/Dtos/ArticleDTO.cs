using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Data.Dtos
{
    class ArticleDTO
    {
        public partial class ArticleDTOIn
        {
            public ArticleDTOIn()
            {
            }
            public string LibelleArticle { get; set; }
            public int? QuantiteStockee { get; set; }
            public int IdCategorie { get; set; }
        }
    }
}
