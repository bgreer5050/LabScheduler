namespace LabManager.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20150118_2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Benches", "Description3");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Benches", "Description3", c => c.String());
        }
    }
}
