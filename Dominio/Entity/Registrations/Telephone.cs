﻿using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Registrations
{
    public class Telephone : EntityBase
    {
        public string Number { get; set; }
        public PhoneType PhoneType { get; set; }
    }
}
