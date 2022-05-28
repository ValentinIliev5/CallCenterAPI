using Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class TestService
    {
        CCDBContext context = new CCDBContext();
        public string getClientName() 
        {
            return context.Clients.First().Name.ToString();
        }

        public string getClientPhone()
        {
            return context.Clients.First().PhoneNumber.ToString();
        }

        public string GetEmployeeName()
        {
            return context.Employees.First().Name.ToString();
        }
    }
}
