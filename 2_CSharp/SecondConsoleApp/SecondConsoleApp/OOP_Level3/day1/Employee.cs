using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.OOP_Level3.day1
{
   
    public class Employee
    {
        public string Name;
        public double Salary;

        public Employee(string name ,double salary)
        {
            Name = name;
            Salary = salary;
            
        }


        public double Annual_Salary()
        {
            double annual = Salary * 12;
            return annual;

        }

        public string Get_Level(double annual)
        {

            if (annual > 12000)
            {
                return("High Salary");
            }

            else if (annual > 6000)
            {
                return ("Medium Salary");
            }

            else if (annual > 3000)
            {
                return ("Low Salary");
            }
            else

            {
                return ("Very Low Salary");
            }

        }




    }
}
