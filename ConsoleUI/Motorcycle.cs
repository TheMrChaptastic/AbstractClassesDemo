using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
            Year = 2021;
            Make = "Ducati";
            Model = "Hypermotard";
        }

        public bool HasSideCart { get; set; } = false;

        public override void DriveAbstract(Vehicle vehicle)
        {
            Console.WriteLine($"I am driving my Motorcycle, it is a: {vehicle.Make} {vehicle.Model}");
        }
    }
}
