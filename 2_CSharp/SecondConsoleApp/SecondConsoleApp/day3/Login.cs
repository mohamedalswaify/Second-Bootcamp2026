using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.day3
{
    internal class Login
    {

        static void Mainn(string[] args)
        {
            //Enter Oprater(*,-,+,/):
            //Login
            Console.Write("Please Enter Your Username: ");

            string username = Console.ReadLine();

            Console.Write("Please Enter Your Password: ");
            string password = Console.ReadLine();

            if (username == "admin" && password == "1234")
            {
                Console.WriteLine("Welcome Admin");
            }
            else
            {
                Console.WriteLine("Invalid Username or Password");
            }




            Console.ReadKey(true);
        }

        }
    }
