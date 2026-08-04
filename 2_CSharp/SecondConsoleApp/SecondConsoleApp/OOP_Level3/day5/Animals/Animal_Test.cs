using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.OOP_Level3.day5.Animals
{
    internal class Animal_Test
    {
        static void Main()
        {
            //Animal a1 = new Animal("Monkey", 8, "White");
            //Dog d2 = new Dog("dog", 6, "Black", "Husky");
            //Cat c3 = new Cat("cat", 5, "Yellow", "yes");

            //Console.WriteLine($"{d2.DisplayInfo()}, {d2.Bark()}");

            //Console.WriteLine($"{c3.DisplayInfo()}, {c3.Meow()}");


            Animal[] animals =
                {
            new Dog("dog", 6, "Black", "Husky"),
            new Cat("cat", 5, "Yellow", "yes")

                 };
            foreach (var animal in animals) {
                Console.WriteLine($"{animal.DisplayInfo()}, {animal.MakeSound()}");
            }

            Console.ReadKey();

            //Interface IAnimal
            //method MakeSound(),DisplayInfo()

            //Class Fish  : IAnimal
            //Feilds: Name,Color,IsFreshWater
            //method DisplayInfo() , MakeSound()

            //Class Bird  : IAnimal
            //Feilds: Name,Color,CanFly
            //method DisplayInfo() , MakeSound()

            //Test Class Animal_Test
            //Create object and add  IAnimal with Fish and Bird objects inside the array of IAnimal and call the methods

        }
    }
}
