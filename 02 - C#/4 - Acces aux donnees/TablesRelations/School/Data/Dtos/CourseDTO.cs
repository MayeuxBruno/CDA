using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static School.Data.Dtos.StudentsCoursesDTO;

namespace School.Data.Dtos
{
    public class CourseDTO
    {
        public partial class CourseDtoIn
        {
            public CourseDtoIn()
            { 
            }
            public int CourseId { get; set; }
            public string CourseName { get; set; }
            public string Description { get; set; }
        }

        public partial class CourseDtoOut
        {
            public CourseDtoOut()
            {
            }
            public string CourseName { get; set; }
            public string Description { get; set; }
        }

        public partial class CourseDtoOutavecStudentCourse
        {
            public CourseDtoOutavecStudentCourse()
            {
                Studentscourses = new HashSet<StudentscourseDtoOutAvecStudents>();
            }
            public int CourseId { get; set; }
            public string CourseName { get; set; }
            public string Description { get; set; }

            public virtual ICollection<StudentscourseDtoOutAvecStudents> Studentscourses { get; set; }
        }
    }
}
