using dotnetcoreTest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcoreTest.Models
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }
        
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Degree> Degrees { get; set; }


    }
}
