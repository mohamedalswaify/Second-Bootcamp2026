using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.OOP_Level3.day2
{
    internal class Patient_Test
    {

            static void Mainn()
            {
                Patient p1 = new Patient("Abdulrhman", -80, 180);


           // p1.Weight = -90;
            double bmi = p1.Get_BMI();
                string status = p1.Get_Status(bmi);

               

                Console.WriteLine(p1.Name);
                Console.WriteLine(p1.Weight);
                Console.WriteLine(p1.Height);
                Console.WriteLine(bmi);
                Console.WriteLine(status);

                Console.ReadKey();
            }
        }
}
