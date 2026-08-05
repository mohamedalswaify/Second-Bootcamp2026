using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.OOP_Level3.day6.Animals
{
    public class Fish :IAnimal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public bool IsFreshWater { get; set; }

        public Fish(string name, string color, bool isFreshWater)
        {
            Name = name;
            Color = color;
            IsFreshWater = isFreshWater;
        }


        public string MakeSound()
        {
            return "Blub Blub";
        }

        public string DisplayInfo()
        {
            return $"Name: {Name}, Color: {Color}, Is Fresh Water: {IsFreshWater}";

        }
    }
}
