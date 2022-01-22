using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public abstract void DriveAbstract(Vehicle vehicle);
        public virtual void DriveVirtual(Vehicle vehicle)
        {
            Console.WriteLine($"I am driving my vehicle, it is a: {vehicle.Year} {vehicle.Make} {vehicle.Model}");
        }
    }
}
