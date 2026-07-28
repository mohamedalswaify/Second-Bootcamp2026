using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.Level2.day2
{
    internal class Calling_Fun
    {

       static void Mainn()
        {


            Fun fun = new Fun();

            //-----------Compute BMI-------------------

            //fun.Compute_BMI();

            //-------------------------------------------




            //-----------Compute BMI2-------------------
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();

            //Console.Write("Enter your weight: ");
            //double weight = double.Parse(Console.ReadLine());

            //Console.Write("Enter your height: ");
            //double height = double.Parse(Console.ReadLine());

            //fun.Compute_BMI2(name,weight,height);
            //-------------------------------------------


            //----------------Void Sum----------------

            //int num1 = 10;
            //int num2 = 20;

            //fun.Sum(num1 , num2);
            //-------------------------------------------

            //----------------return Sum----------------
            int num1 = 10;
            int num2 = 20;
           int res=   fun.Sum2(num1, num2);
            Console.WriteLine(res);
            //-------------------------------------------

            //--------------Void Compute_Salary ----------------

            //Input
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();

            //Console.Write("Enter your salary: ");
            //double salary = double.Parse(Console.ReadLine());

            //fun.Compute_Salary(name, salary);

            //------------------------------------------------------


            //--------------return Compute_Salary ----------------

            // //Input
            // Console.Write("Enter your name: ");
            // string name = Console.ReadLine();

            // Console.Write("Enter your salary: ");
            // double salary = double.Parse(Console.ReadLine());

            //string data =   fun.Compute_Salary2(name, salary);
            // Console.WriteLine(data);

            //------------------------------------------------------





            //-------------- void Compute_PCT---------------------
            //Console.Write("Enter Student Name: ");
            //string name = Console.ReadLine();


            //Console.Write("Enter Student Mark: ");
            //double mark = double.Parse(Console.ReadLine());

            //Console.Write("Enter Student FullMark: ");
            //double fullMark = double.Parse(Console.ReadLine());

            //fun.Compute_PCT(name, mark, fullMark);
            //------------------------------------------------------


            //-------------- return Compute_PCT---------------------
            //Console.Write("Enter Student Name: ");
            //string name = Console.ReadLine();


            //Console.Write("Enter Student Mark: ");
            //double mark = double.Parse(Console.ReadLine());

            //Console.Write("Enter Student FullMark: ");
            //double fullMark = double.Parse(Console.ReadLine());

            //double percentage = fun.Compute_PCT2(name, mark, fullMark); 
            //Console.WriteLine(percentage);
            //------------------------------------------------------


            //-----------return Compute BMI3-------------------
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();

            //Console.Write("Enter your weight: ");
            //double weight = double.Parse(Console.ReadLine());

            //Console.Write("Enter your height: ");
            //double height = double.Parse(Console.ReadLine());

            //double bmi=  fun.Compute_BMI3(name, weight, height);
            //Console.Write(bmi);
            //-------------------------------------------



            //--------------return list Compute_Salary ----------------


            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();

            //Console.Write("Enter your salary: ");
            //double salary = double.Parse(Console.ReadLine());

            //List<object> data = fun.Compute_Salary3(name, salary);

            //foreach (object obj in data)
            //{
            //    Console.WriteLine(obj);
            //}

            //------------------------------------------------------
            //-------------- return list  Compute_PCT---------------------
            //Console.Write("Enter Student Name: ");
            //string name = Console.ReadLine();


            //Console.Write("Enter Student Mark: ");
            //double mark = double.Parse(Console.ReadLine());

            //Console.Write("Enter Student FullMark: ");
            //double fullMark = double.Parse(Console.ReadLine());

            //List<object> data = fun.Compute_PCT3(name, mark, fullMark);

            //foreach (object obj in data)
            //{
            //    Console.WriteLine(obj);
            //}
            //------------------------------------------------------



            //-----------list  Compute BMI3-------------------
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();

            //Console.Write("Enter your weight: ");
            //double weight = double.Parse(Console.ReadLine());

            //Console.Write("Enter your height: ");
            //double height = double.Parse(Console.ReadLine());

            //List<object> data = fun.Compute_BMI4(name, weight, height);
            //foreach (object obj in data)
            //{
            //    Console.WriteLine(obj);
            //}
            //-------------------------------------------






            Console.ReadKey();
        }

    }

}
