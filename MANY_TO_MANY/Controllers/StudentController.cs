using MANY_TO_MANY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MANY_TO_MANY.Controllers
{
    public class StudentController : ApiController
    {
        ModelContext db = new ModelContext();
        [ActionName("all")]
        [HttpGet]
        public IQueryable<StudentDTO> All() {
            var students = from s in db.Students
                           select new StudentDTO { 
                            StudentId = s.StudentId,
                            Name = s.Name,
                            LastName = s.LastName,
                            Age = s.Age
                           };
            return students;
        }

        [ActionName("create")]
        [HttpPost]
        public object Create(Student student)
        {
            db.Students.Add(student);
            db.SaveChangesAsync();
            return student;
        }
    }
}
