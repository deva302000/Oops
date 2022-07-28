using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public class PersonalInfo
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long PhoneNumber { get; set; }
        public string Mail { get; set; }
        public string Gender { get; set; }

        public PersonalInfo(string name,string fatherName,long number,string mail,string gender)
        {
            Name=name;
            FatherName=fatherName;
            PhoneNumber=number;
            Mail=mail;
            Gender=gender;
        }
        
        
        
                
        
        
                
        
    }
}