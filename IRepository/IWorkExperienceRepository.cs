using dotnetcoreTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcoreTest.IRepository
{
    public interface IWorkExperienceRepository
    {
        void CreateWorkExperience(WorkExperience workExperience);
        IEnumerable<WorkExperience> GetAllWorkExperiencesByProfileId(int Id);
        void DeleteWorkExperience(int Id);
    }
}
