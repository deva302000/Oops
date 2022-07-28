using System;
using System.Collections.Generic;
namespace EmployeePayRoll;
class Program 
{
    public static void Main(string[] args)
    {
       //Object
       List<PayRoll> list = new List<PayRoll>();

      
     

       string choice=" ";
       do
       {
           Console.WriteLine("Enter the Name: ");
           string name=Console.ReadLine();

           Console.WriteLine("Enter your Designation: ");
           string designation=Console.ReadLine();

           Console.WriteLine("Enter your Work Location: ");
           string location=Console.ReadLine();

           Console.WriteLine("Enter your Team Name: ");
           string teamname=Console.ReadLine();

           Console.WriteLine("Enter your Date of Joining: ");
           DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

           Console.WriteLine("Enter No of Working Days: ");
           int workdays=Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Enter no. of leave days: ");
           int leavedays=Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Enter your Gender: ");
           string gender=Console.ReadLine();

           PayRoll obj=new PayRoll(name,designation,location,teamname,dob,workdays,leavedays,gender);
           list.Add(obj);

           Console.WriteLine("Do you want to enter another employee details: ");
           choice=Console.ReadLine();

          
       }while(choice=="yes");

       Console.WriteLine("Enter the id that you want to search: ");
       string id=Console.ReadLine();
       foreach(PayRoll i in list)
       {
           if(id==i.EmployeeId)
           {
               i.showDetails();
               int salary=i.SalaryCalculation();
               Console.WriteLine("Salary: "+salary);

           }
       }
       
    }
}