using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MANY_TO_MANY.Models
{
    public class Classroom
    {
        [Key]
        public int ClassroomId { get; set; }
        [Required]
        public string Name { get; set; }
       
        [Required]
        public int SchoolRoom { get; set; }
        
        public virtual ICollection<StudentClassroom> StudentClassrooms { get; set; }
    }
}