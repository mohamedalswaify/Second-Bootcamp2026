using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.Level2.day1
{
    internal class Calling
    {
        static void Mainn()
        {
          
            Methods methods = new Methods();
            
            Console.WriteLine("Choose System:");
            Console.WriteLine("1.Hello");
            Console.WriteLine("2.Sum");
            Console.WriteLine("3.System Employee");
            Console.WriteLine("4.System Student");
            Console.WriteLine("5.System Patient");
            Console.Write("Enter Answer :");
            int answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                Methods.Hello();
            }
            else if (answer == 2)
            {
                methods.Sum();
            }
            else if (answer == 3)
            {
                methods.Compute_Salary();
            }
            else if (answer == 4)
            {
                methods.Compute_PCT();
            }
            else if (answer == 5)
            {
                methods.Compute_BMI();
            }
            else
            {
                Console.WriteLine("Invalid System");
            }
            Console.ReadKey();
        }
      
        
      
        

    }
}
