using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MANY_TO_MANY.Models
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
            : base("name=ModelContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
        public virtual DbSet<Classroom> Classrooms { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentClassroom> StudentClassrooms { get; set; }
    }
}
