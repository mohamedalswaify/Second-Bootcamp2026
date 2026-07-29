using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.OOP_Level3.day2
{
    public class Patient
    {
        public string Name;
        public double Weight;
        public double Height;

        public Patient(string name, double weight, double height)
        {
            Name = name;
            Weight = weight;
            Height = height;

        }

        public double Get_BMI()
        {
            double BMI = Weight / (Height * Height) * 10000;
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
