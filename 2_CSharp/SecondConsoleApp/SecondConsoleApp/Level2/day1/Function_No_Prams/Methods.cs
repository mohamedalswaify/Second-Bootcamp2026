using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.Level2.day1
{
    internal class Methods
    {

     public   static void Hello()
        {
            Console.WriteLine("Welcome Mohamed Alswaify!");
        }
        public  void Sum()
        {
            Console.WriteLine(5 + 6);
        }

        public  void Compute_Salary()
        {
            //Input
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your salary: ");
            double salary = double.Parse(Console.ReadLine());

            //processing
            double annual = salary * 12;


            //Output
            Console.WriteLine("========================");

            Console.WriteLine("Welcome " + name);
            Console.WriteLine("Your Salary " + salary + " SR");
            Console.WriteLine("Your Annual " + annual + " SR");

            if (annual > 12000)
            {
                Console.WriteLine("High Salary");
            }

            else if (annual > 6000)
            {
                Console.WriteLine("Medium Salary");
            }

            else if (annual > 3000)
            {
                Console.WriteLine("Low Salary");
            }
            else

            {
                Console.WriteLine("Very Low Salary");
            }


        }
        public  void Compute_PCT()
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

        public  void Compute_BMI()
        {

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your weight: ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Enter your height: ");
            double height = double.Parse(Console.ReadLine());


            double bmi = weight / (height * height) * 10000;


            Console.WriteLine("Your Name:" + name);
            Console.WriteLine("Your Weight:" + weight + " KG");
            Console.WriteLine("Your height:" + height + " CM");
            Console.WriteLine("Your BMI:" + bmi);

        }





    }
}
