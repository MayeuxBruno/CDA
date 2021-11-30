﻿using System;
using System.Collections.Generic;

#nullable disable

namespace School.Data.Models
{
    public partial class Student
    {
        public Student()
        {
            Studentscourses = new HashSet<Studentscourse>();
        }

        public int StudentId { get; set; }
        public string Name { get; set; }
        public int GradeId { get; set; }

        public virtual ICollection<Studentscourse> Studentscourses { get; set; }
    }
}
