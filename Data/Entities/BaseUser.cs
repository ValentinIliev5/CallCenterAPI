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
        [MaxLength(20)]
        public string Name { get; set; }

        public int Age { get; set; }
        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        public DateTime? CreatedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
