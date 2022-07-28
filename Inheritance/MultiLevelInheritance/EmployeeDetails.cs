using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public class EmployeeDetails : StudentInfo
    {
        private static int s_employeeID=5000;
        public string EmployeeID { get; set; }
        public string Role { get; set; }
        public string OfficeLocation { get; set; }
        public DateTime DOB { get; set; }
        public int Experience { get; set; }

        public EmployeeDetails(string registerNo,string name,string fatherName,long number,string mail,string gender,string standar,char branch, int year,string role,string officeLocation,DateTime dob,int experience):base(registerNo, name, fatherName, number, mail, gender, standar, branch, year)
        {
            s_employeeID++;
            EmployeeID="EID"+s_employeeID;
            Role=role;
            OfficeLocation=officeLocation;
            DOB=dob;
            Experience=experience;
        }

        public void ShowEmployeeDetails()
        {
            Console.WriteLine("Employee ID: "+EmployeeID);
            ShowDetails();
        }
    }
}