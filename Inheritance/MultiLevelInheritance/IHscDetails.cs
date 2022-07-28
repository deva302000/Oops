using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public interface IHscDetails
    {
         int HSCRegisterNo { get; set; }
         int Physics{ get; set;}
         int Chemistry{get; set;}
         int Maths{get; set;}
         double Average{get; set;}
         void GetHSCMarkDetails(int hscRegisterNo, int physics, int chemistry, int maths);
         
         void CalculateHSCAverage();
         
         void ShowHSCDetails();
        
        
        
    }
}