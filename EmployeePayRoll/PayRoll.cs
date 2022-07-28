using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayRoll
{
    public class PayRoll
    {
        private static int s_employeeId=1000;

        public string EmployeeId { get; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string WorkLocation { get; set; }
        public string TeamName { get; set; }
        
        
        public DateTime DateOfJoining { get; set; }
        public int WorkingDays { get; set; }
        public int LeaveDays { get; set; }
        public string Gender { get; set; }

        public PayRoll(string name,string designation,string location,string teamname,DateTime dob,int Working,int leave,string gender)
        {
            s_employeeId++;
            EmployeeId="SF"+s_employeeId;
            Name=name;
            Role=designation;
            WorkLocation=location;
            TeamName=teamname;
            DateOfJoining=dob;
            WorkingDays=Working;
            LeaveDays=leave;
            Gender=gender;

        }

        public void showDetails()
        {
            Console.WriteLine("Customer ID: "+EmployeeId);
            Console.WriteLine("Name:"+Name);
            Console.WriteLine("Designation: "+Role);
            Console.WriteLine("Work Location: "+WorkLocation);
            Console.WriteLine("Team Name: "+TeamName);
            Console.WriteLine("Date of Joining: "+DateOfJoining.ToString("dd/MM/yyyy"));
            Console.Write("No of Working Days: "+WorkingDays);
            Console.WriteLine("No of leave Days: "+LeaveDays);
            Console.WriteLine("Gender: "+Gender);
        }   

        public int SalaryCalculation()
        {
            int days=WorkingDays-LeaveDays;
            int salary=days*500;
            return salary;
            
        }

        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    }
}