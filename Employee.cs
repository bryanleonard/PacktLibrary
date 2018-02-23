using Packt.CS7;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Packt.CS7
{
    public class Employee : Person
    {
        public string EmployeeCode { get; set; }
        public DateTime HireDate { get; set; }

        public new void WriteToConsole()
        {
            WriteLine($"{Name}'s birth date is {DateOfBirth:MM/dd/yy} and hire date was {HireDate:MM/dd/yy}!");
        }

        public override string ToString()
        {
            //return base.ToString();
            //return $"{Name} is a {base.ToString()}";
            return $"{Name}'s code is {EmployeeCode}";
        }
        
    }
}
