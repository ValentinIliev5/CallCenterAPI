namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class restrictions : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "Name", c => c.String(maxLength: 20));
            AlterColumn("dbo.Clients", "PhoneNumber", c => c.String(maxLength: 15));
            AlterColumn("dbo.Employees", "Email", c => c.String(maxLength: 50));
            AlterColumn("dbo.Employees", "Name", c => c.String(maxLength: 20));
            AlterColumn("dbo.Employees", "PhoneNumber", c => c.String(maxLength: 15));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Employees", "Name", c => c.String());
            AlterColumn("dbo.Employees", "Email", c => c.String());
            AlterColumn("dbo.Clients", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Clients", "Name", c => c.String());
        }
    }
}
