using AutoMapper;
using School.Data.Dtos;
using School.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Data.Profiles
{
    public class CourseProfile:Profile
    {
        public CourseProfile()
        {
            CreateMap<Course, CourseDtoIn>();
            CreateMap<CourseDtoIn, Course>();
            CreateMap<Course, CourseDtoOut>();
            CreateMap<CourseDtoOut, Course>();
        }
    }
}
