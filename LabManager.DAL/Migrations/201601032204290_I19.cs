namespace LabManager.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class I19 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ScheduleBlocks", "BenchStatus", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ScheduleBlocks", "BenchStatus");
        }
    }
}
