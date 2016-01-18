namespace LabManager.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class I121 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Qualifications", "Delete", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Qualifications", "Delete");
        }
    }
}
