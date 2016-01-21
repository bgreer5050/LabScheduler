namespace LabManager.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20150121_B : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Benches", "Description5");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Benches", "Description5", c => c.String());
        }
    }
}
