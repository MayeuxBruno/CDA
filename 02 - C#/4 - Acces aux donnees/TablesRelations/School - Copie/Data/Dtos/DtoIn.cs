using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Data.Dtos
{
    public partial class GradeDTOIn
    {
        public GradeDTOIn()
        {
        }

        public int GradeId { get; set; }
        public string GradeName { get; set; }

    }
}
