﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IceOnWheels.Models
{
    public class Stock
    {
        [Required]
        public string TypeIjs { get; set; } // dit of int type 
    }
}
