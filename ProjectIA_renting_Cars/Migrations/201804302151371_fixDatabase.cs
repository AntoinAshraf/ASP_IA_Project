namespace ProjectIA_renting_Cars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixDatabase : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "Prefered_Category_Id", "dbo.categories");
            DropIndex("dbo.Users", new[] { "Prefered_Category_Id" });
            RenameColumn(table: "dbo.Cars", name: "Category_Id", newName: "categoryId");
            RenameColumn(table: "dbo.Users", name: "Prefered_Category_Id", newName: "CategoryId");
            RenameColumn(table: "dbo.Cars", name: "Rented_To_Id", newName: "UserId");
            RenameIndex(table: "dbo.Cars", name: "IX_Category_Id", newName: "IX_categoryId");
            RenameIndex(table: "dbo.Cars", name: "IX_Rented_To_Id", newName: "IX_UserId");
            AlterColumn("dbo.Users", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Users", "CategoryId");
            AddForeignKey("dbo.Users", "CategoryId", "dbo.categories", "Id", cascadeDelete: true);
            DropColumn("dbo.Cars", "Car_Photo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cars", "Car_Photo", c => c.Binary(nullable: false));
            DropForeignKey("dbo.Users", "CategoryId", "dbo.categories");
            DropIndex("dbo.Users", new[] { "CategoryId" });
            AlterColumn("dbo.Users", "CategoryId", c => c.Int());
            RenameIndex(table: "dbo.Cars", name: "IX_UserId", newName: "IX_Rented_To_Id");
            RenameIndex(table: "dbo.Cars", name: "IX_categoryId", newName: "IX_Category_Id");
            RenameColumn(table: "dbo.Cars", name: "UserId", newName: "Rented_To_Id");
            RenameColumn(table: "dbo.Users", name: "CategoryId", newName: "Prefered_Category_Id");
            RenameColumn(table: "dbo.Cars", name: "categoryId", newName: "Category_Id");
            CreateIndex("dbo.Users", "Prefered_Category_Id");
            AddForeignKey("dbo.Users", "Prefered_Category_Id", "dbo.categories", "Id");
        }
    }
}
