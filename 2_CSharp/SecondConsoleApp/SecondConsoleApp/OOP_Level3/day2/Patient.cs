using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.OOP_Level3.day2
{
    public class Patient
    {
        public string Name {  get;  set; }

        private double _weight;
        public double Weight {
            get { return _weight; }
            set
            {
                if (value >= 0)
                {
                    _weight = value;
                }
                else
                {
                    Console.WriteLine("Invalid Weight");
                }
            } 
        }
        public double Height { get; set; }

        public Patient(string name, double weight, double height)
        {
            Name = name;
            Weight = weight;
            Height = height;

        }
        public double Get_BMI()
        {
            double BMI = _weight / (Height * Height) * 10000;
            return BMI;
        }

        public string Get_Status(double BMI)
        {
            if (BMI < 18)
            {
                return ("Underweight");
            }

            else if (BMI >= 18)
            {
                return ("Normal Weight");
            }

            else if (BMI >= 25)
            {
                return ("OverWeight");
            }

            else
            {
                return ("Obese");
            }


        }
    }
    }
