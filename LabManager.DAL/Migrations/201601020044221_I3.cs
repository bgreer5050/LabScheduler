namespace LabManager.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class I3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Benches", "Description2", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Benches", "Description2");
        }
    }
}
