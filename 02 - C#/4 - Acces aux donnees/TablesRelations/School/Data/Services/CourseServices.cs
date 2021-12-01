using Microsoft.EntityFrameworkCore;
using School.Data.Dtos;
using School.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Data.Services
{
    public class CourseServices
    {

        private readonly schoolContext _context;

        public CourseServices(schoolContext context)
        {
            _context = context;
        }

        public void AddCourse(Course obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Courses.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteCourse(Course obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Courses.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return _context.Courses.Include("Studentscourses.Student").ToList();
        }

        public Course GetCourseById(int id)
        {
            return _context.Courses.FirstOrDefault(obj => obj.CourseId == id);
        }

        public void UpdateCourse(Course obj)
        {
            _context.SaveChanges();
        }


    }
}
