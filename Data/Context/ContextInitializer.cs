using Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public  class ContextInitializer : DropCreateDatabaseIfModelChanges<CCDBContext>
    {
        protected override void Seed(CCDBContext context)
        {
            base.Seed(context);

            Employee emp = new Employee();

            emp.Name = "vanio"; 
            emp.Age = 20;
            emp.PhoneNumber = "1111111111";
            emp.CreatedOn = DateTime.Now;
            emp.Email = "vanio@abv.bg";
            emp.IsDeleted = false;
            emp.Salary = 30000;

            context.Employees.Add(emp);
            context.SaveChanges();
        }
    }
}
