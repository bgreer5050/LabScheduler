namespace LabManager.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class I15 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Hours");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Hours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Start = c.Long(nullable: false),
                        End = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
