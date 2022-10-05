using MANY_TO_MANY.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MANY_TO_MANY.Controllers
{
    public class StudentClassroomController : ApiController
    {
        ModelContext db = new ModelContext();
        [HttpGet]
        [ActionName("get-student-by-classroom")]
        public IQueryable<StudentClassroomDTO> GetStudentByClassroom(int id) {
            var result = from sC in db.StudentClassrooms
                         where sC.ClassroomId == id
                         select new StudentClassroomDTO
                         {
                             RelationId = sC.Id,
                             StudentId = sC.Student.StudentId,
                             Name = sC.Student.Name,
                             LastName = sC.Student.LastName,
                             Age = sC.Student.Age,
                             ClassroomId = sC.Classroom.ClassroomId,
                             Classroom = sC.Classroom.Name,
                             SchoolRoom = sC.Classroom.SchoolRoom

                         };
            return result;
        }

        [HttpPost]
        [ActionName("Relation")]
        public object Relation(StudentClassroom studentClassroom)
        {
            db.StudentClassrooms.Add(studentClassroom);
            db.SaveChangesAsync();
            return studentClassroom;
        }
    }
}
