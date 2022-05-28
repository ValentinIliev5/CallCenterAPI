using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Client : BaseUser
    {
        [Key]
        public int Id { get; set; }
        public int CallsMade { get; set; }


    }
}
