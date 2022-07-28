using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public class SBI : Bank
    {
        public override void GetInterestInfo()
        {
            Console.WriteLine("SBI Interest is 7.5%");
        }
    }
}