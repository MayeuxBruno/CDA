using School.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static School.Data.Dtos.StudentDTO;

namespace School.Data.Dtos
{
    public class GradeDTO
    {
        public partial class GradeDTOIn
        {
            public GradeDTOIn()
            {
            }
            public int GradeId { get; set; }
            public string GradeName { get; set; }
        }

        public partial class GradeDtoOut
        {
            public GradeDtoOut()
            {
            }
            public string GradeName { get; set; }
        }

        public class GradeDTOOutavecStudent
        {
            public GradeDTOOutavecStudent()
            {
                Students = new HashSet<StudentDtoOut>();
            }
            public string GradeName { get; set; }
            public virtual ICollection<StudentDtoOut> Students { get; set; }
        }
    }
}
