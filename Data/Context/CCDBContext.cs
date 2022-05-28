using Data.Entities;
using System.Data.Entity;
using System.Configuration;
using System;

namespace Data.Context
{
    public class CCDBContext : DbContext
    {
        public static string GetConnectionString()
        {
            // The connection string needs to exist in the project that executes, not library projects.
            // data source=.\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|aspnetdb.mdf;User Instance=true",
            // machine.config wich is defualt database conneciton string
            return ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }
        //"Server=.;Database=CallCenterDB;Trusted_Connection=True;"
        //ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString
        public CCDBContext() : base(GetConnectionString())
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Call> Calls { get; set; }
    }
    
}
