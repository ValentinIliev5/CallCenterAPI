using Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace Data.Context
{
    public class CCDBContext : DbContext
    {
        public CCDBContext() : base(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString)
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Call> Calls { get; set; }
    }
    
}
