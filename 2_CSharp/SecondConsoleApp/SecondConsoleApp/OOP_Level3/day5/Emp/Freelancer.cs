using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.OOP_Level3.day5
{
    public class Freelancer:IEmployee
    {
        public string Name { get; set; }
        public double ProjectPrice { get; set; }

        public double CalculateAnnualSalary()
        {
            return ProjectPrice * 12;
        }

        public string DisplayEmployeeDetails()
        {
            return $"Freelancer: {Name}";
        }
    }
}
