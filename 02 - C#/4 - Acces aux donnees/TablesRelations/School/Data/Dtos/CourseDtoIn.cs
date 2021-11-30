using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Data.Dtos
{
    public class CourseDtoIn
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
    }
}
