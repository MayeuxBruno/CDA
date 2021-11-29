using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TablesRelation.Data.Dto;
using TablesRelation.Data.Models;

namespace TablesRelation.Data.Profiles
{
    public class TypesproduitProfile:Profile
    {
        public TypesproduitProfile()
        {
            CreateMap<Typesproduit, TypesproduitDTO>();
            CreateMap<TypesproduitDTO, Typesproduit>();
        }
    }
}
