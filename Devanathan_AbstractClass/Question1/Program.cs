using System;
namespace Question1;
class Program 
{
    public static void Main(string[] args)
    {
        Cyclinder cyclinder=new Cyclinder(5.5,7.5);   
        cyclinder.CalculateArea();
        cyclinder.CalculateVolume();

    }
}