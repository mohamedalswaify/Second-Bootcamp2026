using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.day4
{
    internal class Arrays
    {


        static void Mainn(string[] args)
        {

            //int[] numbers = { 10,5,16,20,22};
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);
            //Console.WriteLine(numbers[3]);
            //Console.WriteLine(numbers[4]);



            //string[] names = { "Ali", "Sara", "Ahmed" };

            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);


            //string[] names2 = new string[3];

            //names2[0] = "Ali";
            //names2[1] = "Sara";
            //names2[3] = "Ahmed";


            List<string> list = new List<string>();

            //list[0] = "Html";
            //list[1] = "CSS";
            //list[2] = "JS";

            list.Add("Html");
            list.Add("CSS");
            list.Add("JS");
            list.Add("Flutter");
            list.Add("Dart");


            string[] names = { "Ali", "Sara", "Ahmed" };
            list.AddRange(new List<string> { "Flutter" ,"HTML","CSS"});
            list.AddRange(names);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);

            }

            foreach(string item in list)
            {
                Console.WriteLine(item);
            }




            Console.ReadKey();
        }
    }
}
