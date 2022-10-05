using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;

namespace MANY_TO_MANY.Models
{
    public class StudentClassroom
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        [Required]
        public int ClassroomId { get; set; }
        public virtual Classroom Classroom{ get; set; }
    }
    public class StudentClassroomDTO
    {
        public int RelationId { get; set; }
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int ClassroomId { get; set; }
        public string Classroom { get; set; }
        public int SchoolRoom { get; set; }
    }
}