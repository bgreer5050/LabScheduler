namespace LabManager.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class I8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hours", "HourlyEmployee_Id", c => c.Int());
            CreateIndex("dbo.Hours", "HourlyEmployee_Id");
            AddForeignKey("dbo.Hours", "HourlyEmployee_Id", "dbo.Employees", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Hours", "HourlyEmployee_Id", "dbo.Employees");
            DropIndex("dbo.Hours", new[] { "HourlyEmployee_Id" });
            DropColumn("dbo.Hours", "HourlyEmployee_Id");
        }
    }
}
