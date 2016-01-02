namespace LabManager.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class I10 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hours", "Start", c => c.Long(nullable: false));
            AddColumn("dbo.Hours", "End", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Hours", "End");
            DropColumn("dbo.Hours", "Start");
        }
    }
}
