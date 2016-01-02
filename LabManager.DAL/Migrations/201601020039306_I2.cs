namespace LabManager.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class I2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Benches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        NickName = c.String(),
                        IsActive = c.String(),
                        HoursPerWeek = c.Decimal(precision: 18, scale: 2),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Supervisor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Supervisor_Id)
                .Index(t => t.Supervisor_Id);
            
            CreateTable(
                "dbo.Hours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Qualifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.Int(nullable: false),
                        bench_Id = c.Int(),
                        employee_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Benches", t => t.bench_Id)
                .ForeignKey("dbo.Employees", t => t.employee_Id)
                .Index(t => t.bench_Id)
                .Index(t => t.employee_Id);
            
            CreateTable(
                "dbo.Shifts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartTime = c.Long(nullable: false),
                        EndTime = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Qualifications", "employee_Id", "dbo.Employees");
            DropForeignKey("dbo.Employees", "Supervisor_Id", "dbo.Employees");
            DropForeignKey("dbo.Qualifications", "bench_Id", "dbo.Benches");
            DropIndex("dbo.Qualifications", new[] { "employee_Id" });
            DropIndex("dbo.Qualifications", new[] { "bench_Id" });
            DropIndex("dbo.Employees", new[] { "Supervisor_Id" });
            DropTable("dbo.Shifts");
            DropTable("dbo.Qualifications");
            DropTable("dbo.Hours");
            DropTable("dbo.Employees");
            DropTable("dbo.Benches");
        }
    }
}
