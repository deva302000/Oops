using System;
namespace MultiLevelInheritance;
class Program 
{
    public static void Main(string[] args)
    {
       /* StudentInfo student=new StudentInfo("5088079","Deva","Vaithiyanathan",7200304761,"deva302000vaithiyanathan@gmail.com","Male","VI",'A',2015);
        /student.ShowDetails();
        student.GetHSCMarkDetails(2000,99,99,98);
        student.CalculateHSCAverage();
        student.ShowHSCDetails();*/
        EmployeeDetails employee = new EmployeeDetails("5088079","Deva","Vaithiyanathan",7200304761,"deva302000vaithiyanathan@gamil.com","Male","X",'A',2017,"Developer","Mathura Towers",new DateTime(2000,12,12),5);
        employee.GetHSCMarkDetails(2000,98,97,95);
        employee.CalculateHSCAverage();
        employee.ShowHSCDetails();
        employee.ShowEmployeeDetails();
        
    }
}