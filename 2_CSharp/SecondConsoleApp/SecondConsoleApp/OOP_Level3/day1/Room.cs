using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.OOP_Level3.day1
{
    public class Room
    {

        public double width;
        public double length;

        //ctor
        public Room(double W, double L)
        {
            width= W;
            length= L;
        }




        //Methods

        public double Get_Area()
        {
            double area = width * length;
            return area;
        }





    }
}
