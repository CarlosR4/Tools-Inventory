using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools_Inventory
{
    public class Tool
    {
        //constructor
        public Tool()
        {
            Type = "";
            Number = 0;
            Name = "";
            Make = "";
            Width = 0;
            Height = 0;
            Weight = 0;
        }

        //properties
        public string Type { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public string Make { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
    }
}
