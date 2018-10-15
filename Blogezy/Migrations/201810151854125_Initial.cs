namespace Blogezy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HeaderInfo = c.String(nullable: false, maxLength: 200),
                        ImagePath = c.String(nullable: false),
                        Description = c.String(nullable: false, maxLength: 999),
                        Publishdate = c.DateTime(nullable: false),
                        Category = c.String(nullable: false, maxLength: 50),
                        Commentary = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Articles");
        }
    }
}
