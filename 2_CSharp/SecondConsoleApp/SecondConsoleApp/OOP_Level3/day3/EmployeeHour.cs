using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.OOP_Level3.day3
{
    public class EmployeeHour : Employee
    {
        
      
        public int Hours { get; set; }
        public double HourlyRate { get; set; }

      

        public EmployeeHour(string name, int age, double salary, int hours, double hourlyRate) : base(name, age, salary)
        {
          
            Hours = hours;
            HourlyRate = hourlyRate;
        }

      

    }
}
