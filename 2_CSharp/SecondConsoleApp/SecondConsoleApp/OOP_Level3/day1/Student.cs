using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.OOP_Level3.day1
{
    public class Student
    {
        public string Name;
        public double Mark;
        public int FullMark;
        public Student(string name, double mark, int fullMark)
        {
            Name = name;
            Mark = mark;
            FullMark = fullMark;
        }
        public double Get_PCT()
        {
            double pct = Mark / FullMark * 100;
            return pct;
        }
        public string Get_Grade(double percentage)
        {
            if (percentage > 84)
            {
                return("Excellent");
            }
            else if (percentage > 74)
            {
                return ("Very Good");
            }
            else if (percentage > 64)
            {
                return ("Good");
            }
            else if (percentage >= 50)
            {
                return ("Pass");
            }
            else
            {
                return ("Fail");
            }

        }




    }
}
