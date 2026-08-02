using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.OOP_Level3.day3
{
    internal class Employee_Test
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("John Doe", 30, 5000);
            EmployeeBase e2 = new EmployeeBase("Jane Smith", 28, 6000, 1000);
            EmployeeHour e3 = new EmployeeHour("Mike Johnson", 25, 4000, 160, 25);



           
            Console.WriteLine($" {e1.DisplayEmployeeDetails()  } Annual Salary: {e1.CalculateAnnualSalary()}");
            Console.WriteLine($"{e2.DisplayEmployeeDetails()} Annual Salary: {e2.CalculateAnnualSalary()}");
            Console.WriteLine($"{e3.DisplayEmployeeDetails()}Annual Salary: {e3.CalculateAnnualSalary()}");



            Console.ReadKey();
        }
    }
}
