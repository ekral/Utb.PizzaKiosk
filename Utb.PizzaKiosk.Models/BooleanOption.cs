﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utb.PizzaKiosk.Models
{
    public class BooleanOption : PizzaOption
    {
        public bool IsSelected { get; set; }
        public bool DefaultValue { get; set; }
    }
}
