using dotnetcoreTest.IRepository;
using dotnetcoreTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcoreTest.Repository
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly AppDbContext _context;

        public ProfileRepository(AppDbContext context)
        {
            _context = context;
        }

        public void CreateProfile(Profile profile)
        {
            if (profile != null)
            {
                throw new ArgumentNullException();
            }

            _context.Profiles.Add(profile);
        }

        public Profile GetProfileById(int Id)
        {
            var profile = _context.Profiles.Where(x => x.Id == Id).FirstOrDefault();
            if (profile ==null)
            {
                throw new NullReferenceException();
            }
            return profile;
        }

        public void UpdateProfile(Profile profile)
        {
            if (profile == null)
            {
                throw new ArgumentNullException();
            }

           var existedProfile = _context.Profiles.Where(x => x.Id == profile.Id).FirstOrDefault();

            if (existedProfile == null)
            {
                throw new NullReferenceException();
            }

            existedProfile.Image = profile.Image;
            //existedProfile.Links = profile.Links;
            existedProfile.Name = profile.Name;
            existedProfile.phoneNumber = profile.phoneNumber;
            existedProfile.Skills = profile.Skills;
            existedProfile.WorkExperiences = profile.WorkExperiences;
            existedProfile.About = profile.About;
            existedProfile.Certifications = profile.Certifications;
            existedProfile.Educations = profile.Educations;
            existedProfile.Email = profile.Email;

        }
    }
}
