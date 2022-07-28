using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Cyclinder : CalculatorApp.CircleArea
    {
        private int height;
        public int Height { get; set; }
        internal double Name { get; set; }

        
        public double CalculateVolume()
        {
            double area=CalculateCircleArea();
            double volume=area*height;
            return volume;
        }
        
               
           
    }
}