namespace Data.Migrations
{
    using Data.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.Context.CCDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Data.Context.CCDBContext context)
        {
            context.Clients.AddOrUpdate(new Client() { Name = "az", Age = 15, PhoneNumber = "1213121312", CreatedOn = DateTime.Now, IsDeleted = false, CallsMade=0}) ;
        }
    }
}
