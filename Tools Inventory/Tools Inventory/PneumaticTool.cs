using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools_Inventory
{
    public class PneumaticTool : Tool
    {
        public PneumaticTool()
        {
            Pressure = 0;
            Muffler_Present = false;
        }

        public double Pressure { get; set; }
        public bool Muffler_Present { get; set; }
    }
}
