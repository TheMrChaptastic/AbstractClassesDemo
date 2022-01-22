using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()
        {
            Year = 2010;
            Make = "Hyundai";
            Model = "Elantra";
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
            throw new NotImplementedException();
        }
    }
}
