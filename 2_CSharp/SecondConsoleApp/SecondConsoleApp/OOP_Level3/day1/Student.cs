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

        private double _mark;
        public double Mark { 
            get 
            { 
                return _mark; 
            }
            set 
            {
                if(value >= 0)
                {
                    _mark =value;
                }
                else
                {
                    Console.WriteLine("Invalid Mark");
                }


            } 
        
        }


        private int _FullMark;

        public int FullMark {
            get { return _FullMark; }
            set
            {
                if(value > 0)
                {
                    _FullMark = value;

                }
                else
                {
                    Console.WriteLine("Invalid Full Mark");

                }

            }
        }


        public Student(string name, double mark, int fullMark)
        {
            Name = name;
            Mark = mark;
            FullMark= fullMark;
        }

      


        public double Get_PCT()
        {
            double pct = _mark / _FullMark * 100;
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
