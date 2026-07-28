using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.OOP_Level3.day1
{
    internal class Room_Test
    {

        static void Mainn()
        {



            //double area = Compute_Room(3, 5);
            //Console.WriteLine(area);

            //double area1 = Compute_Room(2, 4);
            //Console.WriteLine(area1);


            Room r1 = new Room(3,5);
            double area = r1.Get_Area();
            Console.WriteLine(area);


            Room r2 = new Room(3, 5);
            double area1 = r2.Get_Area();
            Console.WriteLine(area1);


            Console.ReadLine();
        }


        static double Compute_Room(double width, double length)
        {
 
            double area = width * length;
       
            return area;
        }


    }
}
