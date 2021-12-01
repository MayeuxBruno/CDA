using AutoMapper;
using School.Data.Dtos;
using School.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static School.Data.Dtos.StudentDTO;

namespace School.Data.Profiles
{
    public class StudentProfile:Profile
    {
        public StudentProfile()
        {
            CreateMap<Student, StudentDtoOutavecGrade>();
            CreateMap<StudentDtoOutavecGrade, Student>();
            CreateMap<Student, StudentDtoOutavecCourses>();
            CreateMap<StudentDtoOutavecCourses, Student>();
            CreateMap<Student, StudentDtoOut>();
            CreateMap<StudentDtoOut, Student>();
            CreateMap<Student, StudentDtoIn>();
            CreateMap<StudentDtoIn, Student>();
        }
    }
}
