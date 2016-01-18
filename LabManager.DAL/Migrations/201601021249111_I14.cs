namespace LabManager.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class I14 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Qualifications", "Delete");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Qualifications", "Delete", c => c.String());
        }
    }
}
