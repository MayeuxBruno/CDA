using AutoMapper;
using School.Data.Dtos;
using School.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static School.Data.Dtos.GradeDTO;

namespace School.Data.Profiles
{
    public class GradeProfile:Profile
    {
        public GradeProfile()
        {
              CreateMap<Grade, GradeDtoOut>();
              CreateMap<GradeDtoOut, Grade>();
              CreateMap<Grade, GradeDTOOutavecStudent>();
              CreateMap<GradeDTOOutavecStudent, Grade>();
              CreateMap<Grade, GradeDTOIn>();
              CreateMap<GradeDTOIn, Grade>();
        }
    }
}
