using AutoMapper;
using GestionStock.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GestionStock.Data.Dtos.ArticleDTO;

namespace GestionStock.Data.Profiles
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<Article, ArticleDTOIn>();
            CreateMap<ArticleDTOIn, Article>();
        }
    }
}
