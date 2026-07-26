using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.Level2.day1.Function_return
{
    internal class Calling_Fuction
    {
        static void Main()
        {
            // Create object 
           Functions functions = new Functions();
            //functions.Sum();


            //----------Sum2 ------------------------
            Console.Write("Enter number1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter number2: ");
            int num2 = int.Parse(Console.ReadLine());
            functions.Sum2(num1,num2);
            //-------------------------------------

            //----------Compute salary ------------------------
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();

            //Console.Write("Enter your salary: ");
            //double salary = double.Parse(Console.ReadLine());
            //functions.Compute_sal(name, salary);
            //--------------------------------------


            //----------------Compute PCT---------------
            functions.Compute_PCT();
            //-------------------------------------------




            //----------------Compute PCT2---------------

            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();


            Console.Write("Enter Student Mark: ");
            double mark = double.Parse(Console.ReadLine());

            Console.Write("Enter Student FullMark: ");
            double fullMark = double.Parse(Console.ReadLine());

            functions.Compute_PCT2(name,mark,fullMark);

            //-------------------------------------------



            Console.ReadKey();
        }


    }
}
