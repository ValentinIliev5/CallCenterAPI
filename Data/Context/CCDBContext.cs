using Data.Entities;
using System.Data.Entity;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System;

namespace Data.Context
{
    public class CCDBContext : DbContext
    {
        public static string GetConnectionString()
        {
            string connString ="";
            return connString;
        }
        //"Server=.;Database=CallCenterDB;Trusted_Connection=True;"
        //ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString
        public CCDBContext() : base("Server=.;Database=CallCenterDB;Trusted_Connection=True;")
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Call> Calls { get; set; }
    }
    
}
