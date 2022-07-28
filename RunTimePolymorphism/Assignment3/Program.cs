using System;
namespace Assignment3;
class Program 
{
    public static void Main(string[] args)
    {
        Shape s;
        s=new Line();
        s.DrawShape();

        s=new Pyramid();
        s.DrawShape();

        s=new Square();
        s.DrawShape();

        s=new Rectangle();
        s.DrawShape();
    }
}