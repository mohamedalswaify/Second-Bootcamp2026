using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.Level2.day2
{
    internal class Fun
    {

        // ---------------------Void Function---------------------------------------
        public void Compute_BMI()
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


        }

        public void Compute_BMI2(string name="null", double weight=80, double height=190)
        {
           


            double bmi = weight / (height * height) * 10000;


            Console.WriteLine("Your Name:" + name);
            Console.WriteLine("Your Weight:" + weight + " KG");
            Console.WriteLine("Your height:" + height + " CM");
            Console.WriteLine("Your BMI:" + bmi);


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


        }

        //--------------------------------------------------------------------------


        public void Sum(int num1 , int num2)
        {
            int res= num1 + num2;
            Console.WriteLine(res);
        }


        public int Sum2(int num1, int num2)
        {
            int res = num1 + num2;
            return res;
        }



        public void Compute_Salary(string name, double salary)
        {
            //processing
            double annual = salary * 12;

            Console.WriteLine("Your Annual " + annual + " SR");
        }

        public string Compute_Salary2(string name, double salary)
        {
            //processing
            double annual = salary * 12;
            string data = $"Your name {name} Your Annual {annual}  SR";

          return data;
        }


        public void Compute_PCT(string name, double mark, double fullMark)
        {

            double percentage = mark / fullMark * 100;


            Console.WriteLine("Student Name:" + name);
            Console.WriteLine("Student Mark:" + mark);
            Console.WriteLine("Student FullMark:" + fullMark);
            Console.WriteLine("Student Percentage:" + percentage + "%");

        }


        public double Compute_PCT2(string name, double mark, double fullMark)
        {

            double percentage = mark / fullMark * 100;
            return percentage;

        }


        public double Compute_BMI3(string name = "null", double weight = 80, double height = 190)
        {

            double bmi = weight / (height * height) * 10000;

            return bmi;

        }

        public List<object> Compute_Salary3(string name, double salary)
        {
            //processing
            double annual = salary * 12;

            List<object> data = new List<object>();
            data.Add(name);
            data.Add(salary);
            data.Add(annual);

            return data;
        }
        public List<object> Compute_PCT3(string name, double mark, double fullMark)
        {
            double percentage = mark / fullMark * 100;
            List<object> data = new List<object>();
            data.Add(name);
            data.Add(mark);
            data.Add(percentage);

            return data;

        }


        public List<object> Compute_BMI4(string name , double weight, double height)
        {
            double bmi = weight / (height * height) * 10000;

            List<object> data = new List<object>();
            data.Add(name);
            data.Add(weight);
            data.Add(height);
            data.Add(bmi);

            return data;

        }


    }
}
