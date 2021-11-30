using School.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static School.Data.Dtos.DtoOut;

namespace School.Data.Services
{
    public class GradeServices
    {

        private readonly schoolContext _context;

        public GradeServices(schoolContext context)
        {
            _context = context;
        }

        public void AddGrade(Grade obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Grades.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteGrade(Grade obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Grades.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Grade> GetAllGrades()
        {
            return _context.Grades.ToList();
        }

        public Grade GetGradeById(int id)
        {
            return _context.Grades.FirstOrDefault(obj => obj.GradeId == id);
        }

        public void UpdateGrade(Grade obj)
        {
            _context.SaveChanges();
        }


    }
}
