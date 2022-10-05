namespace MANY_TO_MANY.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classrooms",
                c => new
                    {
                        ClassroomId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SchoolRoom = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClassroomId);
            
            CreateTable(
                "dbo.StudentClassrooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        ClassroomId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classrooms", t => t.ClassroomId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.ClassroomId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentClassrooms", "StudentId", "dbo.Students");
            DropForeignKey("dbo.StudentClassrooms", "ClassroomId", "dbo.Classrooms");
            DropIndex("dbo.StudentClassrooms", new[] { "ClassroomId" });
            DropIndex("dbo.StudentClassrooms", new[] { "StudentId" });
            DropTable("dbo.Students");
            DropTable("dbo.StudentClassrooms");
            DropTable("dbo.Classrooms");
        }
    }
}
