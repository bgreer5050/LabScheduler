namespace LabManager.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20160127_2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ScheduleBlocks", "Bench_Id", "dbo.Benches");
            DropForeignKey("dbo.ScheduleBlocks", "Employee_Id", "dbo.Employees");
            DropIndex("dbo.ScheduleBlocks", new[] { "Bench_Id" });
            DropIndex("dbo.ScheduleBlocks", new[] { "Employee_Id" });
            CreateTable(
                "dbo.BenchStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StatusCode = c.Int(nullable: false),
                        employee_Id = c.Int(),
                        Hour_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.employee_Id)
                .ForeignKey("dbo.Hours", t => t.Hour_Id)
                .Index(t => t.employee_Id)
                .Index(t => t.Hour_Id);
            
            CreateTable(
                "dbo.Hours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Time = c.DateTime(nullable: false),
                        HourNo = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.ScheduleBlocks");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ScheduleBlocks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Hour = c.DateTime(nullable: false),
                        BenchStatus = c.Int(nullable: false),
                        Bench_Id = c.Int(),
                        Employee_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.BenchStatus", "Hour_Id", "dbo.Hours");
            DropForeignKey("dbo.BenchStatus", "employee_Id", "dbo.Employees");
            DropIndex("dbo.BenchStatus", new[] { "Hour_Id" });
            DropIndex("dbo.BenchStatus", new[] { "employee_Id" });
            DropTable("dbo.Hours");
            DropTable("dbo.BenchStatus");
            CreateIndex("dbo.ScheduleBlocks", "Employee_Id");
            CreateIndex("dbo.ScheduleBlocks", "Bench_Id");
            AddForeignKey("dbo.ScheduleBlocks", "Employee_Id", "dbo.Employees", "Id");
            AddForeignKey("dbo.ScheduleBlocks", "Bench_Id", "dbo.Benches", "Id");
        }
    }
}
