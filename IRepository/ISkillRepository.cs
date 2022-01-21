using dotnetcoreTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcoreTest.IRepository
{
    public interface ISkillRepository
    {
        void CreateSkill(Skill skill);
        IEnumerable<Skill> GetAllSkillsByProfileId (int Id);
        void DeleteSkill(int Id);
     }
}
