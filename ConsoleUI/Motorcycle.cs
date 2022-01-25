using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {

        public bool HasSideCart { get; set; } = false;

        public override void DriveVirtual()
        {
            Console.WriteLine($"The Car Peels Out (Virtual Override)");
        }
        public override void DriveAbstract()
        {
            Console.WriteLine($"The Motorcylce Peels Out (Abstract)");
        }
    }
}
