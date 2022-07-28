using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class CircleArea : MathsLib.Maths
    {
        protected double radius;
        public double Radius { get; set; }
        internal string Area { get; set; }
        public CircleArea()
        {
            Console.WriteLine("Enter the value of Radius: ");
            double radius=Convert.ToDouble(Console.ReadLine());
            Radius=radius;
        }
        public double CalculateCircleArea()
        {
            double area=Pi*Radius*Radius;
            return area;
        }
        
        
        
           
    }


    class Cylinder : CircleArea
    {
        

    }
}