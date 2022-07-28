using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3
{
    public class MethodOverloading
    {
        public void Display (int a)
        {
            Console.WriteLine("Integer method called");
            int square=a*a;
            Console.WriteLine("Square is "+square);
        }

        public void Display(float a)
        {
            Console.WriteLine("Float method called");
            float square=a*a;
            Console.WriteLine("Square is: "+square);
        }

        public void Display(double a)
        {
            Console.WriteLine("Double method called");
            double square=a*a;
            Console.WriteLine("Square is: "+square);
        }

        public void Display(long a)
        {
            Console.WriteLine("Long method called");
            long square=a*a;
            Console.WriteLine("Square is: "+square);
        }
    }
}