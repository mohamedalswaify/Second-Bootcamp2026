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
        private double Salary;

        public Employee(string name ,double salary)
        {
            Name = name;
            Set_Salary(salary);


        }

        public double Get_Salary()
        {
            return Salary;
        }

        public void Set_Salary(double salary)
        {
            if(salary >=0)
            {
                Salary = salary;
            }
            else
            {
                Console.WriteLine("Invalid Salary");
            }


            
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
