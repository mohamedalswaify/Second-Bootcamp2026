using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.OOP_Level3.day6.Animals
{
    public class Dog : Animal
    {
        public string Breed { get; set; }
        public Dog(string name, int age, string color, string breed) : base(name, age, color)
        {
            Breed = breed;
        }
        public override string DisplayInfo()
        {
            return base.DisplayInfo()+ $" , Breed: {Breed}";
        }
        public string Bark()
        {
            return("I am Class Dog");
        }

        public override string MakeSoundAbstract()
        {
            return "Bark";
        }

    }
}
