using School.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Data.Dtos
{
    public class StudentDtoOutavecGrade
    {
        public string Name { get; set; }
        public int GradeId { get; set; }
        public virtual GradeDtoOut Grade { get; set; }
    }
}
