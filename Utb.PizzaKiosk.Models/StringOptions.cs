﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utb.PizzaKiosk.Models
{
    public class StringOptions : PizzaOption
    {
        public required List<string> Options { get; set; }
        public required int DefaultValueIndex { get; set; }
        public bool IsDefault(string value) => Options.IndexOf(value) == DefaultValueIndex;

    }
}
