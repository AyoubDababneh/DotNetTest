using dotnetcoreTest.IRepository;
using dotnetcoreTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcoreTest.Repository
{
    public class SkillRepository : ISkillRepository
    {
        private readonly AppDbContext _context;

        public SkillRepository(AppDbContext context)
        {
            _context = context;
        }
        public void CreateSkill(Skill skill)
        {
            if (skill == null)
            {
                throw new ArgumentNullException();
            }

            _context.Add(skill);
        }

        public void DeleteSkill(int Id)
        {
            var skill = _context.Skills.Where(x => x.Id == Id).FirstOrDefault();

            if (skill == null)
            {
                throw new NullReferenceException();
            }

            _context.Skills.Remove(skill);
        }

        public IEnumerable<Skill> GetAllSkillsByProfileId(int Id)
        {
            var skill = _context.Skills.Where(x => x.ProfileId == Id).ToList();

            if (skill == null)
            {
                throw new NullReferenceException();
            }

            return skill;
        }
    }
}
