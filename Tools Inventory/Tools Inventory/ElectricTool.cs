using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools_Inventory
{
    public class ElectricTool: Tool
    {
        public ElectricTool() : base()
        {
            Watts = 0;
            Volts = 0;
            Amps = 0;
        }

        public double Watts { get; set; }
        public double Volts { get; set; }
        public double Amps { get; set; }
    }
}
