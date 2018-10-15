namespace Blogezy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MainHeadertableAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MainHeaders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Header = c.String(nullable: false),
                        Content = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MainHeaders");
        }
    }
}
