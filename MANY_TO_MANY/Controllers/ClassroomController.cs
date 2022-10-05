using MANY_TO_MANY.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.EnterpriseServices;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;

namespace MANY_TO_MANY.Controllers
{
    public class ClassroomController : ApiController
    {
        ModelContext db = new ModelContext();
        [HttpGet]
        [ActionName("all")]
        public IQueryable<Classroom> All() {
            return db.Classrooms;
        }

        [HttpPost]
        [ActionName("create")]
        public object Create(Classroom classroom) 
        {
            db.Classrooms.Add(classroom);
            db.SaveChangesAsync();
            return classroom;
        }

    }
}
