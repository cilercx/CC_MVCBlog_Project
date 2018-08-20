namespace MVCBLOG.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstcs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contact",
                c => new
                    {
                        ContactId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        Surname = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false),
                        Subject = c.String(nullable: false),
                        Message = c.String(nullable: false),
                        CreatedDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        CreatedUserName = c.String(maxLength: 30),
                        ModifiedUserName = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.ContactId);
            
            CreateTable(
                "dbo.File",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FileName = c.String(),
                        FileUrl = c.String(),
                        FileSize = c.Int(),
                        FileExtension = c.String(),
                        FileType = c.String(),
                        CreatedDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        CreatedUserName = c.String(maxLength: 30),
                        ModifiedUserName = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.File");
            DropTable("dbo.Contact");
        }
    }
}
