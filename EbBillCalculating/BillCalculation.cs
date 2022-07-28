using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EbBillCalculating
{
    public class BillCalculation
    {
        private static int s_meterID=1000;
        public string MeterID { get;  }
        public string Name { get; set; }
        public long Phone { get; set; }
        public string Mail { get; set; }
        public int Unit { get; set; }

        public BillCalculation(string name,long phone,string mail,int unit)
        {
            s_meterID++;
            MeterID="EB"+s_meterID;
            Name=name;
            Phone=phone;
            Mail=mail;
            Unit=unit;

        }

       

        public int Calculation(int unit)
        {
        int amount=0;
        
            if(unit<=100)
            {
                return amount;
            }

            if(unit<=200)
            {
                amount=(unit-100)*2;
                return amount;
            }
            if(unit<=400)
            {
                amount=((unit-200)*4+(100*2));
                return amount;

            }
            if(unit<=600)
            {
                amount=((unit-400)*6+(200*4)+(100*2));
            }
            return 0;
        }
        
        
        
        
        
        
        
        
        
        
    }
}