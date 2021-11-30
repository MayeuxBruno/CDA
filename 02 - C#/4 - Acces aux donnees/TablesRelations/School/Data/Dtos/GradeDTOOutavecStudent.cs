using School.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Data.Dtos
{
    public class GradeDTOOutavecStudent
    {
        public string GradeName { get; set; }
        public virtual ICollection<StudentDtoOut> Students { get; set; }
    }
}
