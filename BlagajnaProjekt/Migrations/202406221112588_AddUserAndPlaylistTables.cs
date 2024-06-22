namespace BlagajnaProjekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserAndPlaylistTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Songs",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 100),
                        Artist = c.String(nullable: false, maxLength: 100),
                        FilePath = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Songs");
        }
    }
}
