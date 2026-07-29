using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.OOP_Level3.day1
{
  //  Patient  Patient_Test
    internal class Student_Test
    {
        static void Mainn()
        {
            Student s1 = new Student("Mohamed", 35, 50);
            s1.Set_Mark(38);
            double pct = s1.Get_PCT();
            string grade = s1.Get_Grade(pct);
            Console.WriteLine(s1.Name);
            Console.WriteLine(s1.Get_Mark());
            Console.WriteLine(s1.FullMark);
            Console.WriteLine(pct);
            Console.WriteLine(grade);
                
            Console.ReadKey();
        }
    }
}
