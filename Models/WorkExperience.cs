
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcoreTest.Models
{
    public class WorkExperience
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        // Resposibilities
        [Required]
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }
    }
}
