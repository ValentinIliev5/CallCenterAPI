using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTOs
{
    public class CallDTO
    {
        public int Id { get; set; }

        public DateTime DateOfCall { get; set; }

        public DateTime StartOfCall { get; set; }

        public DateTime EndOfCall { get; set; }

        public int EmployeeId { get; set; }

        public int ClientId { get; set; }
    }
}
