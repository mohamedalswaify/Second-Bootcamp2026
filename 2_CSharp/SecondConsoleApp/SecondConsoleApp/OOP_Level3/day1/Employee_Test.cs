using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.OOP_Level3.day1
{
    internal class Employee_Test
    {
        //Student -- Student_Test
        static void Mainn()
        {
        

            Employee e1 = new Employee("Mohamed", -1000);
           // e1.Set_Salary(500);
            double annual = e1.Annual_Salary();
            string level = e1.Get_Level(annual);
            Console.WriteLine(e1.Name);
            Console.WriteLine(e1.Get_Salary());
            Console.WriteLine(annual);
            Console.WriteLine(level);

            
            Console.ReadKey();
        }
    }
}
