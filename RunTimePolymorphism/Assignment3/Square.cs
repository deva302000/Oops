using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Square : Shape
    {
        public override void DrawShape()
        {
            Console.WriteLine("Square called");
            Console.WriteLine("????????");
            Console.WriteLine("?      ?");
            Console.WriteLine("?      ?");
            Console.WriteLine("????????"); 
        }
    }
}