using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.OOP_Level3.day5.Animals
{
    public class Cat : Animal
    {
        private string IsIndoor { get; set; }

        public Cat(string name, int age, string color, string is_in_door) : base(name, age, color)
        {
            IsIndoor = is_in_door;
        }
        public override string DisplayInfo()
        {
            return base.DisplayInfo()+ $" ,Is in Door: {IsIndoor}";
        }
        public string Meow()
        {
            return ("I am Class Cat");
        }
    }
}
