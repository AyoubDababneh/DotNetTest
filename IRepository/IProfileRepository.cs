using dotnetcoreTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcoreTest.IRepository
{
    public interface IProfileRepository
    {
        void CreateProfile(Profile profile);
        Profile GetProfileById(int Id);
        void UpdateProfile(Profile profile);

    }
}
