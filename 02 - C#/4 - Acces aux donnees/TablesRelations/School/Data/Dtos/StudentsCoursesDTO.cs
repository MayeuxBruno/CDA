using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static School.Data.Dtos.CourseDTO;
using static School.Data.Dtos.StudentDTO;

namespace School.Data.Dtos
{
    public class StudentsCoursesDTO
    {
        public partial class StudentscourseDtoIn
        {
            public StudentscourseDtoIn()
            {
            }
            public int StudentCourseId { get; set; }
            public int? StudentId { get; set; }
            public int? CourseId { get; set; }
        }

        public partial class StudentscourseDtoOut
        {
            public StudentscourseDtoOut()
            {
            }
            public int StudentCourseId { get; set; }
            public int? StudentId { get; set; }
            public int? CourseId { get; set; }
        }

        public  partial class StudentscourseDtoOutAvecStudents
        {
            public StudentscourseDtoOutAvecStudents()
            {
            }
            public virtual StudentDtoOut Student { get; set; }
        }

        public partial class StudentscourseDtoOutAvecCourses
        {
            public StudentscourseDtoOutAvecCourses()
            {
            }
            public virtual CourseDtoOut Course { get; set; }

        }
        public partial class StudentscourseDtoOutAvecStudentsCourses
        {
            public StudentscourseDtoOutAvecStudentsCourses()
            {
            }
            public virtual StudentDtoOut Student { get; set; }
            public virtual CourseDtoOut Course { get; set; }

        }
    }
}
