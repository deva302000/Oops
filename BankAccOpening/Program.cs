using System;
using System.Collections.Generic;
namespace BankAccOpening;
class Program 
{
    public static void Main(string[] args)
    {
        List<AccountDetails> accountList=new List<AccountDetails>();

        string choice="";
        do
        {
             AccountDetails account=new AccountDetails();
            Console.Write("Enter Customer Name: ");
            account.CustomerName=Console.ReadLine();

            Console.Write("Enter your Balance: ");
            account.Balance=Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your Gender: ");
            account.Gender=Console.ReadLine();

            Console.Write("Enter your Phone NUmber: ");
            account.Phone=Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter your mailID: ");
            account.Mail=Console.ReadLine();

            Console.Write("Enter your DoB: ");
            account.DateOfBirth=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
           

            Console.WriteLine("Do you want to Enter another Details: ");
            choice=Console.ReadLine();
            accountList.Add(account);

            

        }while(choice=="yes");
        
        Console.WriteLine("Enter your Customer ID: ");
        string id=Console.ReadLine().ToUpper();
        foreach(AccountDetails list in accountList)
        {
            if(id==list.CustomerID)
            {
            list.showDetails();

            Console.WriteLine("Enter the amount for deposit: ");
            int deposit=Convert.ToInt32(Console.ReadLine());
            double amount=list.deposit(deposit);
            Console.WriteLine("Amount Deposited: "+amount);

            Console.WriteLine("Enter the amount for WithDraw: ");
            int withdraw=Convert.ToInt32(Console.ReadLine());
            double amount1=list.withDraw(withdraw);
            Console.WriteLine("Balance is"+amount1);

            list.showBalance();
            }
        }

        
    }
}