using System;
namespace Question1;
class Program 
{
    public static void Main(string[] args)
    {
        Dog dog1=new Dog("Jacky","Street","Meals");
        Console.WriteLine("Dog First object called");
        dog1.DisplayName();   
        Console.WriteLine();
        Dog dog2=new Dog("Blacky","DogHome","Pedigree");
        Console.WriteLine("Dog Second Object called");
        dog2.DisplayName();
        Console.WriteLine();

        Duck duck1=new Duck("Duck","River","Insect");
        Console.WriteLine("Duck first object called");
        duck1.DisplayName();
        Console.WriteLine();
        Duck duck2=new Duck("Duck2","Lake","Fish");
        Console.WriteLine("Duck second object called");
        duck2.DisplayName();
        Console.WriteLine();

    }
}