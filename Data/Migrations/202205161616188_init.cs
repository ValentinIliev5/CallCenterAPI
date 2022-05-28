namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Calls",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateOfCall = c.DateTime(nullable: false),
                        StartOfCall = c.DateTime(nullable: false),
                        EndOfCall = c.DateTime(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CallsMade = c.Int(nullable: false),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        PhoneNumber = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Salary = c.Single(nullable: false),
                        Email = c.String(),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        PhoneNumber = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Calls", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Calls", "ClientId", "dbo.Clients");
            DropIndex("dbo.Calls", new[] { "ClientId" });
            DropIndex("dbo.Calls", new[] { "EmployeeId" });
            DropTable("dbo.Employees");
            DropTable("dbo.Clients");
            DropTable("dbo.Calls");
        }
    }
}
