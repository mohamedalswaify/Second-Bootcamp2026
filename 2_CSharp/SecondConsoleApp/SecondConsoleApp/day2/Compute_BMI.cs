using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.day2
{
    internal class Compute_BMI
    {

        static void Main(string[] args)
        {
            //Compute_BMI

            //Enter your name: Ahmed
            //Enter your weight: 70
            //Enter your height: 175

            //BMI = weight / (height * height) * 10000 


            // Your Name: Ahmed
            // Your Weight: 70 KG
            // Your Height: 175 CM
            // Your BMI: 22.86


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


            //>=30 Obese
            //>18  <25 Normal  weight
            //>25 <30 Overweight
            //<18 Underweight


            Console.ReadKey(true);




        }



    }
}
