using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathsLib
{
    public  class Maths
    {
        protected internal double Pi=3.14;
        internal double g=9.8;

        public void CalculateWeight()
        {
            Console.WriteLine("Enter the Mass value: ");
            double mass=Convert.ToDouble(Console.ReadLine());
            double weight=mass*g;
        }   
    }
}