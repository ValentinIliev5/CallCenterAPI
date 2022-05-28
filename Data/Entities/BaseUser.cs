using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public abstract class BaseUser
    {
        
        public string Name { get; set; }

        public int Age { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime? CreatedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
