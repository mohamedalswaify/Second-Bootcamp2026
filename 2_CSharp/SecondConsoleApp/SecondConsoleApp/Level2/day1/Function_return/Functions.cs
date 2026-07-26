using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.Level2.day1.Function_return
{
    internal class Functions
    {


        // Function with no Paramter
       public   void Sum()
        {

            Console.Write("Enter number1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter number2: ");
            int num2 = int.Parse(Console.ReadLine());

            int res =num1 + num2;

            Console.WriteLine(res);
        }

        // Function with  Paramter
        public void Sum2(int num1, int num2)
        {
           
            int res = num1 + num2;

            Console.WriteLine(res);
        }


        public void Compute_sal(string name, double salary)
        {

           
            //processing
            double annual = salary * 12;

            Console.WriteLine("Welcome " + name);
            Console.WriteLine("Your Salary " + salary + " SR");
            Console.WriteLine("Your Annual " + annual + " SR");


        }



        public void Compute_PCT()
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


        public void Compute_PCT2(string name, double mark, double fullMark)
        {

           

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




    }
}
