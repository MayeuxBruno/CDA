using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Data.Dtos
{
    public class StudentscourseDtoOut
    {
            public int StudentCourseId { get; set; }
            public int? StudentId { get; set; }
            public int? CourseId { get; set; }
    }
}
