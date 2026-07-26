using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.day3
{
    internal class Check_day_v2
    {


        static void Mainn(string[] args)
        {

            //Check_day_v2
            //Enter Your day:
            //1 Workday
            //2 Workday
            //3 Workday
            //4 Workday
            //5 Workday
            //6 Offday
            //7 Offday
            //Invalid day
            Console.WriteLine("Enter Your day:");
            int day = int.Parse(Console.ReadLine());

            string dayName;
            if (day >= 1 && day <= 5)
            {
                dayName = "Workday";
            }
            else if (day == 6  || day == 7)
            {
                dayName = "Offday";
            }
            else
            {
                dayName = "Invalid day";
            }


            Console.WriteLine(dayName);



            Console.ReadKey(true);
        }
    }
}
