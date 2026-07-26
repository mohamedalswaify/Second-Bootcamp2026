using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.day3
{
    internal class Compute_BMI_V2
    {
        static void Mainn(string[] args)
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


            //>= 30 Obese
            //>=25  Overweight
            //>=18 < Normal weight
            //<=18 Underweight


    
            //<18 Underweight
            //<25 Normal weight
            //<30 Overweight
            //>=30 Obese


            if (bmi >= 30)
            {
                Console.WriteLine("Obese");
            }
            else if (bmi >= 25)
            {
                Console.WriteLine("Overweight");
            }
            else if (bmi >= 18)
            {
                Console.WriteLine("Normal weight");
            }
            else
            {
                Console.WriteLine("Underweight");
            }



           
















            Console.ReadKey(true);




        }


    }
}
