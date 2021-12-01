using Microsoft.EntityFrameworkCore;
using School.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Data.Services
{
    public class StudentServices
    {
        private readonly schoolContext _context;

        public StudentServices(schoolContext context)
        {
            _context = context;
        }

        public void AddStudent(Student obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Students.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteStudent(Student obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Students.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _context.Students.Include("Studentscourses.Course").Include("Grade").ToList();
        }

        public Student GetStudentById(int id)
        {
            return _context.Students.FirstOrDefault(obj => obj.StudentId == id);
        }

        public void UpdateStudent(Student obj)
        {
            _context.SaveChanges();
        }
    }
}
