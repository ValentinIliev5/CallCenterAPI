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

        public string DateOfCall { get; set; }

        public string StartOfCall { get; set; }

        public string EndOfCall { get; set; }

        public string Details { get; set; }
        public int EmployeeId { get; set; }

        public int ClientId { get; set; }
    }
}
