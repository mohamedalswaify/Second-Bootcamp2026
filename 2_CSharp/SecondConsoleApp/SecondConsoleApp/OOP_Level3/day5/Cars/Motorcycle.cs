using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.OOP_Level3.day5.Car
{
    public class Motorcycle : Vehicle
    {
        public string HasSideCar { get; set; }

        public Motorcycle(string brand, string model, double price, string has_side_car)
            : base(brand, model, price)
        {
            HasSideCar = has_side_car;
        }
        public override string DisplayDetails()
        {
            return base.DisplayDetails()+ $" Has SideCar: {HasSideCar}";
        }

        public string DoWheelie()
        {
            return ("Motorcycle is doing a wheelie!");
        }
    }
}
