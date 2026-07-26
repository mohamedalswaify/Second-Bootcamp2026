using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.day3
{
    internal class Check_day
    {


        static void Mainn(string[] args)
        {

            //Check_day
            //Enter Your day:
            //1 Sunday
            //2 Monday
            //3 Tuesday
            //4 Wednesday
            //5 Thursday
            //6 Friday
            //7 Saturday
            //Invalid day
            Console.WriteLine("Enter Your day:");
            int day = int.Parse(Console.ReadLine());
            string dayName ;
            if (day == 1)
            {
                dayName = "Sunday";
                
            }
            else if (day == 2)
            {
                dayName = "Monday";
               
            }
            else if (day == 3) {
                dayName = "Tuesday";
            }
            else if (day == 4)
            {
                dayName = "Wednesday";
            }
            else if (day == 5)
            {
                dayName = "Thursday";
            }
            else if (day == 6)
            {
                dayName = "Friday";
            }
            else if (day == 7)
            {
                dayName = "Saturday";
            }
            else
            {
                dayName = "Invalid day";
            }


            Console.WriteLine(dayName);


        }
        }
}
