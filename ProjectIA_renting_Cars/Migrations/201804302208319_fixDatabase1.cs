namespace ProjectIA_renting_Cars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixDatabase1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.categories", "category_Name", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "SSN", c => c.String(nullable: false, maxLength: 14));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "SSN", c => c.String(nullable: false));
            AlterColumn("dbo.categories", "category_Name", c => c.String());
        }
    }
}
