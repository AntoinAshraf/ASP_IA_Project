namespace ProjectIA_renting_Cars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixDatabase3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Balance", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Balance", c => c.Int(nullable: false));
        }
    }
}
