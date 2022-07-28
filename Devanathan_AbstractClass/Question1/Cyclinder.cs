using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class Cyclinder : Shape
    {
        
        public  override double Area { get; set; }
        public override double Volume { get; set; }
     
        
        public Cyclinder(double radius,double height)
        {
            Radius=radius;
            Height=height;
        }
        public  override void CalculateArea()
        {
            double Area=2*3.14*Radius*(Radius+Height);
            Console.WriteLine("Area is "+Area);

        }    

        public override void CalculateVolume()
        {
            double Volume=3.14*Radius*Radius*Height;
            Console.WriteLine("Volume is "+Volume);
        }
    }
}