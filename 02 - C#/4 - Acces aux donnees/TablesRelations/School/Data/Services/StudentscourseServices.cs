﻿using School.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Data.Services
{
    public class StudentscourseServices
    {

        private readonly schoolContext _context;

        public StudentscourseServices(schoolContext context)
        {
            _context = context;
        }

        public void AddStudentscourse(Studentscourse obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Studentscourses.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteStudentcourse(Studentscourse obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Studentscourses.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Studentscourse> GetAllStudentscourse()
        {
            return _context.Studentscourses.ToList();
        }

        public Studentscourse GetStudentCourseById(int id)
        {
            return _context.Studentscourses.FirstOrDefault(obj => obj.StudentCourseId == id);
        }

        public void UpdatenomModel(Studentscourse obj)
        {
            _context.SaveChanges();
        }


    }
}
