using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Call
    {
        [Key]
        public int Id { get; set; }

        public DateTime DateOfCall { get; set; }

        public DateTime StartOfCall { get; set; }

        public DateTime EndOfCall { get; set; }
        [MaxLength(20)]
        public string Details { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        public int EmployeeId { get; set; }

        [ForeignKey("ClientId")]
        public Client Client { get; set; }

        public int ClientId { get; set; }
    }
}
