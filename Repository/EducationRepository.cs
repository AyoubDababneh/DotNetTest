using dotnetcoreTest.IRepository;
using dotnetcoreTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcoreTest.Repository
{
    public class EducationRepository : IEducationRepository
    {
        private readonly AppDbContext _context;

        public EducationRepository (AppDbContext context)
        {
            _context = context;
        }
        public void CreateEducation(Education education)
        {
            if (education == null)
            {
                throw new ArgumentNullException();
            }

            _context.Educations.Add(education);
            _context.SaveChanges();
        }

        public void DeleteEducation(int Id)
        {
            var education = _context.Educations.Where(x => x.Id == Id).FirstOrDefault();
            if (education == null)
            {
                throw new NullReferenceException();
            }
            _context.Educations.Remove(education);
        }

        public IEnumerable<Education> GetAllEducationByProfileId(int Id)
        {
            var education = _context.Educations.Where(x => x.ProfileId == Id).ToList();
            if (education == null)
            {
                throw new NullReferenceException();
            }
            return education;
        }
    }
}
