using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public class HDFC : Bank
    {
        public override void GetInterestInfo()
        {
            Console.WriteLine("HDFC Interest is 10%");   
        }
    }
}