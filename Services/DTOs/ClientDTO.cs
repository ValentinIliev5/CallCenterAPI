﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTOs
{
    public class ClientDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public string PhoneNumber { get; set; }

        public int CallsMade { get; set; }
    }
}
