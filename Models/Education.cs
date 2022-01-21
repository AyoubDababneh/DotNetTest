using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcoreTest.Models
{
    public class Education
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string InstitutionName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [Required]
        public int DegreeId { get; set; }
        public Degree Degree { get; set; }
        [Required]
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }
    }
}
