using School.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static School.Data.Dtos.GradeDTO;
using static School.Data.Dtos.StudentsCoursesDTO;

namespace School.Data.Dtos
{
    public class StudentDTO
    {
        public partial class StudentDtoIn
        {
            public StudentDtoIn()
            {
            }
            public string Name { get; set; }
            public int GradeId { get; set; }
        }

        public partial class StudentDtoOut
        {
            public StudentDtoOut()
            {
            }
            public string Name { get; set; }
        }

        public partial class StudentDtoOutavecCourses
        {
            public StudentDtoOutavecCourses()
            {
                Studentscourses = new HashSet<StudentscourseDtoOutAvecCourses>();
            }
            public string Name { get; set; }
            public virtual GradeDtoOut Grade { get; set; }
            public virtual ICollection<StudentscourseDtoOutAvecCourses> Studentscourses { get; set; }
        }

        public partial class StudentDtoOutavecGrade
        {
            public StudentDtoOutavecGrade()
            {
            }
            public string Name { get; set; }
            public int GradeId { get; set; }
            public virtual GradeDtoOut Grade { get; set; }
        }
    }
}
