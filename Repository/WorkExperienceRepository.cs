using dotnetcoreTest.IRepository;
using dotnetcoreTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcoreTest.Repository
{
    public class WorkExperienceRepository : IWorkExperienceRepository
    {
        private readonly AppDbContext _context;

        public WorkExperienceRepository( AppDbContext context)
        {
            _context = context;
        }
        public void CreateWorkExperience(WorkExperience workExperience)
        {
            if (workExperience == null)
            {
                throw new ArgumentNullException();
            }
            _context.WorkExperiences.Add(workExperience);
        }

        public void DeleteWorkExperience(int Id)
        {
            var workExperience = _context.WorkExperiences.Where(x => x.Id == Id).FirstOrDefault();

            if (workExperience == null)
            {
                throw new NullReferenceException();
            }

            _context.WorkExperiences.Remove(workExperience);
        }

        public IEnumerable<WorkExperience> GetAllWorkExperiencesByProfileId(int Id)
        {
            var workExperiences = _context.WorkExperiences.Where(x => x.ProfileId == Id).ToList();

            if (workExperiences == null)
            {
                throw new NullReferenceException();
            }

            return workExperiences;
        }
    }
}
