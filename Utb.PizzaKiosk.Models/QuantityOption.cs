using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utb.PizzaKiosk.Models
{
    class QuantityOption : PizzaOption
    {
        public required int DefaultValue { get; set; }
        public required int MinimalValue { get; set; }
        public required int MaximalValue { get; set; }

    }
}
