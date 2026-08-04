using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.OOP_Level3.day5
{
    public abstract class Employee :IEmployee
    {

        //Employee 
        //Properties Name ,Age,Salary
        //Method DisplayEmployeeDetails() int All the properties of Employee
        //Method CalculateAnnaulSalary() int return Salary *12  of Employee

        //EmployeeBase 
        //Properties Name ,Age,Salary,Bonus
        //Method DisplayEmployeeDetails() int All the properties of EmployeeBase
        //Method CalculateAnnaulSalary() int return Salary *12  of EmployeeBase

        //EmployeeHour 
        //Properties Name ,Age,Salary,Hours,HourlyRate
        //Method DisplayEmployeeDetails() int All the properties of EmployeeHour
        //Method CalculateAnnaulSalary() int return Salary *12  of EmployeeHour

        public string Name { get; set; }

        public int Age { get; set; }

        private double _salary;
        public double Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value >= 0)
                {
                    _salary = value;
                }
                else
                {
                    throw new ArgumentException("Salary cannot be negative.");

                }
            }
        }


        public Employee(string name,int age ,double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;

        }



        public virtual string DisplayEmployeeDetails()
        {

            return $"Name: {Name}, Age: {Age}, Salary: {Salary}";
        }

        public abstract double CalculateAnnualSalary();
       
      
      



    }
}
