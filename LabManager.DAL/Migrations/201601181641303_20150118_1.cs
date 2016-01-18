namespace LabManager.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20150118_1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Benches", "Description3", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Benches", "Description3");
        }
    }
}
