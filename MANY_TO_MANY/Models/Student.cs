using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MANY_TO_MANY.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string LastName { get; set; }

        public virtual ICollection<StudentClassroom> StudentClassrooms { get; set; }
    }
    public class StudentDTO {
        public int StudentId { get; set; }
        public string Name { get; set; }    
        public int Age { get; set; }  
        public string LastName { get; set; }
    }
}