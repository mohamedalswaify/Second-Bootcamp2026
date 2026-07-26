using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.day4
{
    internal class Compute_PCT_v2
    {

        static void Mainn(string[] args)
        {


            for (int i = 1; i <= 3; i++)
            {


            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();


            Console.Write("Enter Student Mark: ");
            double mark = double.Parse(Console.ReadLine());

            Console.Write("Enter Student FullMark: ");
            double fullMark = double.Parse(Console.ReadLine());


            double percentage = mark / fullMark * 100;


            Console.WriteLine("Student Name:" + name);
            Console.WriteLine("Student Mark:" + mark);
            Console.WriteLine("Student FullMark:" + fullMark);
            Console.WriteLine("Student Percentage:" + percentage + "%");


      


            if (percentage > 84)
            {
                Console.WriteLine("Excellent");
            }

            else if (percentage > 74)
            {
                Console.WriteLine("Very Good");
            }
            else if (percentage > 64)
            {
                Console.WriteLine("Good");
            }

            else if (percentage >= 50)
            {
                Console.WriteLine("Pass");
            }

            else
            {
                Console.WriteLine("Fail");
            }


            }






            Console.ReadKey(true);
        }
    }
}
