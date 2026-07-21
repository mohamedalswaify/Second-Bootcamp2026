using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.day3
{
    internal class Calc_v2
    {

        static void Mainn(string[] args)
        {


            //Calc 
            //Enter Number1: 5
            //Enter Number2: 10

            //Sum: number1 + Number2 = 15
            //Sub: number1 - Number2 = -5
            //Mul: number1 * Number2 = 50
            //Div: number1 / Number2 = 0.5


            //Enter Number1: 5
            //Enter Number2: 10
            //Sum: 15
            //Sub: -5
            //Mul: 50
            //Div: 0.5
           // Enter Oprater(*,-,+,/):

            Console.Write("Enter Number1: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.Write("Enter Number2: ");
            double number2 = double.Parse(Console.ReadLine());

            Console.Write("Enter Oprater(*,-,+,/): ");
            string oprater = Console.ReadLine();

            if(oprater== "+")
            {
                double sum = number1 + number2;
                Console.WriteLine("Result: " + sum);
            }
            else if (oprater == "-")
            {
                double sub = number1 - number2;
                Console.WriteLine("Result: " + sub);
            }
            else if (oprater == "*")
            {
                double mul = number1 * number2;
                Console.WriteLine("Result: " + mul);
            }
            else if (oprater == "/")
            {
                double div = number1 / number2;
                Console.WriteLine("Result: " + div);
            }
            else
            {
                Console.WriteLine("Invalid Oprater");
            }


          

           






            Console.ReadKey(true);
        }
    }
}
