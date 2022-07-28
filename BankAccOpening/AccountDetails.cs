using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccOpening
{
    public class AccountDetails
    {
        private static int s_customerID=1000;
        public string CustomerID{get;}
        
        public string CustomerName { get; set; }
        public double Balance { get; set; }
        public string Gender { get; set; }
        public long Phone { get; set; }
        public string Mail { get; set; }
        public DateTime DateOfBirth { get; set; }

        public AccountDetails()
        {
            s_customerID++;
            CustomerID="HDFC"+s_customerID;
        }

        double amount;
        public double deposit(int cash)
        {
            amount=Balance+cash;
            return amount;

        }

        public double withDraw(int withDraw)
        {
            Balance=amount-withDraw;
            return Balance;

        }

        public void showBalance()
        {
            Console.WriteLine("Your Balance is: "+Balance);

        }

        public void showDetails()
        {
            
            Console.WriteLine("Customer ID:"+CustomerID);
            Console.WriteLine("Customer Name"+CustomerName);
            Console.WriteLine("Balance: "+Balance);
            Console.WriteLine("Gender: "+Gender);
            Console.WriteLine("Phone Number: "+Phone);
            Console.WriteLine("mail ID: "+Mail);
            Console.WriteLine("DateOfBirth: "+DateOfBirth.ToString("dd/MM/yyyy"));
        }
        

        
        
        
        
        
        
        
        
        
        
        
        
    }
}