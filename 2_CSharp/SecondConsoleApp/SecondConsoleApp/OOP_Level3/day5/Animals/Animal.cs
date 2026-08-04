using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.OOP_Level3.day5.Animals
{
    public abstract class Animal
    {
        public string Name;
        private int age;
        public string Color;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Invalied Age");
                }
            }
        }
        public Animal(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
        }
        public virtual string DisplayInfo()
        {
            return $" Name: {Name}, Age: {Age}, Color: {Color}";
        }

            public string MakeSound()
        {
            return("Animal is making a sound");
        }
    }
}
