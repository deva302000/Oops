using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace  MultiLevelInheritance

{
    public class CustomerDetails : PersonalInfo
    {
        private static int s_customerID=1000;
        public string CustomerID { get; set; }
        public double WalletBalance { get; set; }
        
        
        public CustomerDetails(string name,string fatherName,long number,string mail,string gender,string standar,char branch, int year):base(name,fatherName,number,mail,gender)
        {
            s_customerID++;
            CustomerID="SF"+s_customerID;
        }


        public void Recharge()
        {
            Console.WriteLine("Enter the amount you want to recharge:  ");
            double balance=Convert.ToInt32(Console.ReadLine());
            WalletBalance+=balance;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Customer Id: "+CustomerID);
            Console.WriteLine("Name            : "+Name);
            Console.WriteLine("Father Name     : "+FatherName);
            Console.WriteLine("Phone Number    : "+PhoneNumber);
            Console.WriteLine("Mail ID         : "+Mail);
            Console.WriteLine("Gender          ; "+Gender);
            Console.WriteLine("Wallent balance : "+WalletBalance);
        }
        
        
        

    }
}