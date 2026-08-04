using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.OOP_Level3.day5
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

        public override double CalculateAnnualSalary()
        {
            double annual = (Salary +(Hours * HourlyRate)) * 12;
            return annual;
        }

        public override string DisplayEmployeeDetails()
        {

            return base.DisplayEmployeeDetails()+ $"Hours {Hours},HourlyRate {HourlyRate}";
        }

    }
}
