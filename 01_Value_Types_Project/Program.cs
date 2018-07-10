using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Value_Types_Project
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello! What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            var age = Console.ReadLine();
            var chosenAge = Convert.ToInt32(age);

            Console.WriteLine($"Hello {name}, what kind of vehicle will you be insuring?");
            Console.WriteLine("1: Car, 2: Motorcycle, 3: Boat, 4: Airplane");
            var vehicle = Convert.ToInt32(Console.ReadLine());
            var chosenVehicle = (Vehicles) vehicle;
            var ageBracket = 0;
            var total = 0;

            if (chosenAge >= 18 && chosenAge <= 27)
            {
                ageBracket = 1;
            }else if (chosenAge >= 27 && chosenAge <= 64)
            {
                ageBracket = 2;
            }else if (chosenAge >= 65)
            {
                ageBracket = 3;
            }

            switch (chosenVehicle)
            {
                case Vehicles.Car:
                    switch (ageBracket)
                    {
                        case 1:
                            total = 150;
                            break;
                        case 2:
                            total = 50;
                            break;
                        case 3:
                            total = 100;
                            break;
                    }
                    break;
                case Vehicles.Motorcycle:
                    switch (ageBracket)
                    {
                        case 1:
                            total = 200;
                            break;
                        case 2:
                            total = 100;
                            break;
                        case 3:
                            total = 250;
                            break;
                    }
                    break;
                case Vehicles.Boat:
                    switch (ageBracket)
                    {
                        case 1:
                            total = 200;
                            break;
                        case 2:
                            total = 100;
                            break;
                        case 3:
                            total = 150;
                            break;
                    }
                    break;
                case Vehicles.Plane:
                    switch (ageBracket)
                    {
                        case 1:
                            total = 1000;
                            break;
                        case 2:
                            total = 500;
                            break;
                        case 3:
                            total = 1000;
                            break;
                    }
                    break;
            }
            Console.WriteLine($"Your insurance estimate is ${total} per month.");
            Console.ReadLine();
        }
        private enum Vehicles
        {
            Car = 1,
            Motorcycle = 2,
            Boat = 3,
            Plane = 4
        }
    }
}
