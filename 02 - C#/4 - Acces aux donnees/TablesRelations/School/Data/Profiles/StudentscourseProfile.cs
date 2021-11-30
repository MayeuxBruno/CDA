using AutoMapper;
using School.Data.Dtos;
using School.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Data.Profiles
{
    public class StudentscourseProfile:Profile
    {
        public StudentscourseProfile()
        {
            CreateMap<Studentscourse, StudentscourseDtoIn>();
            CreateMap<StudentscourseDtoIn, Studentscourse>();
            CreateMap<Studentscourse, StudentscourseDtoOut>();
            CreateMap<StudentscourseDtoOut, Studentscourse>();
            CreateMap<Studentscourse, StudentscourseDtoOutAvecStudents>();
            CreateMap<StudentscourseDtoOutAvecStudents, Studentscourse>();
            CreateMap<Studentscourse, StudentscourseDtoOutAvecStudentsCourses>();
            CreateMap<StudentscourseDtoOutAvecStudentsCourses, Studentscourse>();
        }
    }
}
