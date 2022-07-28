using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class StudentInfo : IDisplayInfo
    {
        public string StudentID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long Mobile { get; set; }
        
        public StudentInfo(string studentID,string name, string fatherName,long mobile)
        {
            StudentID=studentID;
            Name=name;
            FatherName=fatherName;
            Mobile=mobile;
        }
        
        public void Display()
        {
            Console.WriteLine("StudentID: "+StudentID);
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Father Name: "+FatherName);
            Console.WriteLine("Mobile Number: "+Mobile);
        }
    }
}