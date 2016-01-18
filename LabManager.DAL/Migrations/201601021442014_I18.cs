namespace LabManager.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class I18 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Benches", "Description4", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Benches", "Description4");
        }
    }
}
