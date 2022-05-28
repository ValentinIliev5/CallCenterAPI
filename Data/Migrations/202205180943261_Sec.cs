namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Sec : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "DeletedOn", c => c.DateTime());
            AlterColumn("dbo.Employees", "DeletedOn", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "DeletedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Clients", "DeletedOn", c => c.DateTime(nullable: false));
        }
    }
}
