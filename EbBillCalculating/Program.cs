using System;
using System.Collections.Generic;
namespace EbBillCalculating;
class Program 
{
    public static void Main(string[] args)
    {
        List<BillCalculation> list=new List<BillCalculation>();

        string choice=" ";
        do{
            
            Console.WriteLine("Enter your Name: ");
            string name=Console.ReadLine();

            Console.WriteLine("Enter your Phone Number: ");
            long phone=Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter your mailID:");
            string mail=Console.ReadLine();

            Console.WriteLine("Enter amount of Unit Consumed: ");
            int unit=Convert.ToInt32(Console.ReadLine());


            BillCalculation bill=new BillCalculation(name,phone,mail,unit); 
            choice=Console.ReadLine();



            
        }while(choice=="yes");

        Console.WriteLine("Enter your MeterID: ");
        string id=Console.ReadLine();
        foreach(BillCalculation i in list)
        {
            if(id==i.MeterID)
            {
                int amount=i.Calculation(i.Unit);
            }
        }
        
    }
}