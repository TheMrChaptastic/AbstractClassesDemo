using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; } = 2012;
        public string Make { get; set; } = "Unidentified";
        public string Model { get; set; } = "Vehicle";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"The Vehicle Peels Out (Virtual)");
        }
    }
}
