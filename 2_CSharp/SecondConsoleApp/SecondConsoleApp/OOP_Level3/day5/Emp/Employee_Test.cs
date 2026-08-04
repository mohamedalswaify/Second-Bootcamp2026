using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.OOP_Level3.day5
{
    internal class Employee_Test
    {
        static void Mainn(string[] args)
        {


            //Employee[] employees = 
            //{
            //new EmployeeBase("Jane Smith", 28, 1000, 500),
            //new EmployeeHour("Mike Johnson", 25, 1000, 10, 60)};

            //foreach (var employee in employees)
            //{
            //    Console.WriteLine($"{employee.DisplayEmployeeDetails()} Annual Salary: {employee.CalculateAnnualSalary()}");
            //}   


            IEmployee[] employees =
          {
            new EmployeeBase("Jane Smith", 28, 1000, 500),
            new EmployeeHour("Mike Johnson", 25, 1000, 10, 60),
            new Freelancer ()

            };

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.DisplayEmployeeDetails()} Annual Salary: {employee.CalculateAnnualSalary()}");
            }


            Console.ReadKey();
        }
    }
}
