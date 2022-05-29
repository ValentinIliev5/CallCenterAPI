namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CallsUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Calls", "Details", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Calls", "Details");
        }
    }
}
