using System;
namespace Assignment2;
class Program 
{
    public static void Main(string[] args)
    {
        Bank b;
        b=new SBI();
        b.GetInterestInfo();

        b=new ICICI();
        b.GetInterestInfo();

        b=new HDFC();
        b.GetInterestInfo();

        b=new IDBI();
        b.GetInterestInfo();
    }
}