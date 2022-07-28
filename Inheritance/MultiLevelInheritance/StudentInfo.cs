using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace  MultiLevelInheritance

{
    public class StudentInfo : PersonalInfo , IHscDetails
    {
       // private static int s_registerNumber=1000; 
        public string RegisterId { get;  }
        public string Standar { get; set; }
        public char Branch { get; set; }
        public int AcademicYear { get; set; }
        

         public int HSCRegisterNo { get; set; }
        public int Physics{ get; set;}
        public int Chemistry{get; set;}
        public int Maths{get; set;}
        public double Average{get; set;}
        public StudentInfo(string registerNo,string name,string fatherName,long number,string mail,string gender,string standar,char branch, int year):base(name,fatherName,number,mail,gender)
        {
            //s_registerNumber++;
            RegisterId=registerNo;
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

        public interface IHscDetails
        {
           
        }
        public void GetHSCMarkDetails(int hscRegisterNo, int physics, int chemistry, int maths)
        {
            HSCRegisterNo=hscRegisterNo;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
            
        }

        public void CalculateHSCAverage()
        {
            Average=(Maths+Physics+Chemistry)/3;
        }

        public void ShowHSCDetails()
        {
            Console.WriteLine("Register No: "+HSCRegisterNo);
            Console.WriteLine("Physics: "+Physics);
            Console.WriteLine("Chemistry: "+Chemistry);
            Console.WriteLine("Maths: "+Maths);
            Console.WriteLine("Average: "+Average);
        }
        
        
        
        
        
        
        
        
    }
}