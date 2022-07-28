using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public class IDBI : Bank
    {
        public override void GetInterestInfo()
        {
            Console.WriteLine("IDBI Interest is 6%");
        }
    }
}