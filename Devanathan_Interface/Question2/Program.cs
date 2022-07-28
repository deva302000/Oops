using System;
namespace Question2;
class Program 
{
    public static void Main(string[] args)
    {
        StudentInfo student = new StudentInfo("SF3005","Deva","Vaithiyanathan",7200304761);
        student.Display();

        EmployeeInfo employee = new EmployeeInfo("EID2000","Deva","God") ;
        employee.Display();
    }
}

    
