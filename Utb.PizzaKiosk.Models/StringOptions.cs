using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utb.PizzaKiosk.Models
{
    public class StringOptions : PizzaConfigurationOption
    {
        public required List<string> Options { get; set; }
        public required int DefaultValueIndex { get; set; }
        public bool IsDefault(string value) => true;

    }
}
