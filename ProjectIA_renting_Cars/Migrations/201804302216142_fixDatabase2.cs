namespace ProjectIA_renting_Cars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixDatabase2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "CategoryId", "dbo.categories");
            DropIndex("dbo.Users", new[] { "CategoryId" });
            AlterColumn("dbo.Users", "CategoryId", c => c.Int());
            CreateIndex("dbo.Users", "CategoryId");
            AddForeignKey("dbo.Users", "CategoryId", "dbo.categories", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "CategoryId", "dbo.categories");
            DropIndex("dbo.Users", new[] { "CategoryId" });
            AlterColumn("dbo.Users", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Users", "CategoryId");
            AddForeignKey("dbo.Users", "CategoryId", "dbo.categories", "Id", cascadeDelete: true);
        }
    }
}
