using dotnetcoreTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcoreTest.IRepository
{
    public interface IEducationRepository
    {
        void CreateEducation(Education education);
        IEnumerable<Education> GetAllEducationByProfileId(int Id);
        void DeleteEducation(int Id);
    }
}
