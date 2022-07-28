using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public class ICICI : Bank
    {
        public  override void GetInterestInfo()
        {
            Console.WriteLine("ICICI Interest is 7%");
        }
    }
}