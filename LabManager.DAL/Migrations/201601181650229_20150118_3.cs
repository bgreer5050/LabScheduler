namespace LabManager.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20150118_3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Benches", "Description5", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Benches", "Description5");
        }
    }
}
