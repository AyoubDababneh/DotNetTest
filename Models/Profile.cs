using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcoreTest.Models
{
    public class Profile
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        //public List<string> Links { get; set; }
        [Required]
        public string phoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        public string About { get; set; }
        public string Image { get; set; }
        public List<Education> Educations { get; set; }
        public List<Certification> Certifications { get; set; }
        public List<Skill> Skills { get; set; }
        public List<WorkExperience> WorkExperiences { get; set; }


    }
}
