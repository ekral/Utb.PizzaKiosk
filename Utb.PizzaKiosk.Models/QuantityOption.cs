using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utb.PizzaKiosk.Models
{
    class QuantityOption : PizzaOption
    {
        public int Quantity { get; set; }
        public int DefaultValue { get; set; }
    }
}
