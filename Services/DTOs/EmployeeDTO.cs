using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTOs
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public string PhoneNumber { get; set; }

        public float Salary { get; set; }

        public string Email { get; set; }

    }
}
