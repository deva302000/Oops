using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public class MethodOverloading
    {
        public void Display(int value)
        {
            Console.WriteLine("One Argument mehtod called");
            value=value*value;
            Console.WriteLine("Square of the Given number: "+value);
        }

        public void Display(int value1,int value2)
        {
            Console.WriteLine("Two argument and same type method called");
            Console.WriteLine("First value: "+value1+" Second value: "+value2);
        }

        public void Display(int a,int b, int c)
        {
            Console.WriteLine("Three argument with same type method called");
            Console.WriteLine($" Value 1: {a} \n Value 2: {b} \n Value 3: {c}");
        }

        public void Display(int a,char b)
        {
            Console.WriteLine("Two argument with different type method called");
            Console.WriteLine($" Value 1: {a} \n Value 2: {b}");
        }

        public void Display(int a,char b,string c)
        {
            Console.WriteLine("Three arguments with different type called");
            Console.WriteLine($" Value 1: {a} \n Value 2: {b} \n Value 3: {c}");
        }
    }
}