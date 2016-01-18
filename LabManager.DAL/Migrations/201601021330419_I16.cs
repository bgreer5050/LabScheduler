namespace LabManager.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class I16 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ScheduleBlocks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Hour = c.DateTime(nullable: false),
                        Bench_Id = c.Int(),
                        Employee_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Benches", t => t.Bench_Id)
                .ForeignKey("dbo.Employees", t => t.Employee_Id)
                .Index(t => t.Bench_Id)
                .Index(t => t.Employee_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ScheduleBlocks", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.ScheduleBlocks", "Bench_Id", "dbo.Benches");
            DropIndex("dbo.ScheduleBlocks", new[] { "Employee_Id" });
            DropIndex("dbo.ScheduleBlocks", new[] { "Bench_Id" });
            DropTable("dbo.ScheduleBlocks");
        }
    }
}
