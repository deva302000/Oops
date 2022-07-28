using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Pyramid : Shape
    {
        public override void DrawShape()
        {
            
            Console.WriteLine("Pyramid \n");
            Console.WriteLine("   /\\");
            Console.WriteLine("  /  \\");
            Console.WriteLine(" /    \\");
            Console.WriteLine("/______\\");
             
        }
    }
}