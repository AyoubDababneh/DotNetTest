using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcoreTest.Models
{
    public class Certification
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime GraduteDate { get; set; }
        [Required]
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }
    }
}
