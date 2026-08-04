using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.OOP_Level3.day5
{
    public class EmployeeBase : Employee,IPrintable,IEmployee
    {

        public double Bonus { get; set; }

        public EmployeeBase(string name, int age, double salary,double bouns) : base(name, age, salary)
        {
          
            Bonus = bouns;
        }

        public override double CalculateAnnualSalary()
        {
            double annual = (Salary+Bonus) * 12;
            return annual;
        }

        public override string DisplayEmployeeDetails()
        {

            return base.DisplayEmployeeDetails() +  $"Bouns {Bonus}";
        }

        public void Print()
        {
            Console.WriteLine("Welcome");
        }

       
    }
}
