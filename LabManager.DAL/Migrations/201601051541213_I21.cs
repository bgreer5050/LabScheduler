namespace LabManager.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class I21 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Benches", "Description4");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Benches", "Description4", c => c.String());
        }
    }
}
