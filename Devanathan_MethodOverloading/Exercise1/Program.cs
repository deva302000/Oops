using System;
namespace Exercise1;
class Program 
{
    public static void Main(string[] args)
    {
        MethodOverloading methodOverloading = new MethodOverloading();
        methodOverloading.Display(3);
        methodOverloading.Display(3,4);
        methodOverloading.Display(1,2,3);
        methodOverloading.Display(5,'A');
        methodOverloading.Display(5,'C',"Deva");
    }
}