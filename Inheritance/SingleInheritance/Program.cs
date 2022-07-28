using System;
namespace SingleInheritance;
class Program 
{
    public static void Main(string[] args)
    {
        StudentInfo student=new StudentInfo("Deva","Vaithiyanathan",7200304761,"deva302000vaithiyanathan@gmail.com","Male","VI",'A',2015);
        student.ShowDetails();
    }
}