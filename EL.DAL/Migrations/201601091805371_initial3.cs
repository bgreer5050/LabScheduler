namespace EL.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial3 : DbMigration
    {
        public override void Up()
        {
            RenameIndex(table: "dbo.EntryUpdates", name: "IX_EntryUpdate_Entry_Id", newName: "IX_Entry_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.EntryUpdates", name: "IX_Entry_Id", newName: "IX_EntryUpdate_Entry_Id");
        }
    }
}
