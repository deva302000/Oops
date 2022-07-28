using System;
namespace Exercise3;
class Program 
{
    public static void Main(string[] args)
    {
        MethodOverloading methodOverloading=new MethodOverloading();
        methodOverloading.Display(5);
        methodOverloading.Display(10.5f);
        methodOverloading.Display(22.53284298349234023409234723094);
        methodOverloading.Display(123456789098761);
    }
}