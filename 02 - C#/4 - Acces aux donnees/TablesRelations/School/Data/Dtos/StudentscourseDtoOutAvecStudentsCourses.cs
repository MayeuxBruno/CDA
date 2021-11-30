using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Data.Dtos
{
    public class StudentscourseDtoOutAvecStudentsCourses
    {
            public virtual StudentDtoOut Student { get; set; }
            public virtual CourseDtoOut Course { get; set; }

    }
}
