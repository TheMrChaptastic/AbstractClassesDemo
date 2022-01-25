using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()
        {
        }
        public Car(int y, string make, string model)
        {
            Year = y;
            Make = make;
            Model = model;
        }

        public bool HasTrunk { get; set; } = true;

        public override void DriveAbstract(Vehicle vehicle)
        {
            Console.WriteLine($"I am driving my Car, it is a: {vehicle.Year} {vehicle.Make} {vehicle.Model}");
        }
    }
}
