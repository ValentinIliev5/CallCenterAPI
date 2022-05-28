namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class baseChange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "CreatedOn", c => c.DateTime());
            AlterColumn("dbo.Employees", "CreatedOn", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "CreatedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Clients", "CreatedOn", c => c.DateTime(nullable: false));
        }
    }
}
