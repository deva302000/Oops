using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    public class StudentInfo : PersonalInfo
    {
        private static int s_registerNumber=1000; 
        public string RegisterId { get;  }
        public string Standar { get; set; }
        public char Branch { get; set; }
        public int AcademicYear { get; set; }

        public StudentInfo(string name,string fatherName,long number,string mail,string gender,string standar,char branch, int year):base(name,fatherName,number,mail,gender)
        {
            s_registerNumber++;
            RegisterId="SF"+s_registerNumber;
            Standar=standar;
            Branch=branch;
            AcademicYear=year;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Registeration ID: "+RegisterId);
            Console.WriteLine("Name            : "+Name);
            Console.WriteLine("Father Name     : "+FatherName);
            Console.WriteLine("Phone Number    : "+PhoneNumber);
            Console.WriteLine("Mail ID         : "+Mail);
            Console.WriteLine("Gender          ; "+Gender);
            Console.WriteLine("Standard        : "+Standar);
            Console.WriteLine("Branch          : "+Branch);
            Console.WriteLine("Academic Year   : "+AcademicYear);
        }
        
        
        
        
        
        
        
        
    }
}