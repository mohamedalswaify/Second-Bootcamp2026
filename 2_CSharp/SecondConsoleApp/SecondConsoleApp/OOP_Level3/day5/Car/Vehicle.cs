using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.OOP_Level3.day5.Car
{
    public abstract class Vehicle
    {

        public string Brand { get; set; }
        public string Model { get; set; }
        private double _Price;
        public double Price
        {
            get
            {

                return _Price;
            }
            set
            {
                if (value >= 0)
                {
                    _Price = value;
                }
                else
                {
                    Console.WriteLine("Invalied Price");
                }
            }
        }
        public Vehicle(string brand, string model, double price)
        {
            Brand = brand;
            Model = model;
            Price = price;
        }
        public virtual string DisplayDetails()
        {
            return $"Brand: {Brand}, Model: {Model}, Price: {Price}";
        }

        

    }
}
