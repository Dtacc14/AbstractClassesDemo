using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public int NumberOfWheels { get; set; }
        public override string DriveAbstract()
        {
            return $"I am a car! I have {NumberOfWheels} wheels.";
        }
        public override void DriveVirtual()
        {
            base.DriveVirtual();
        }
    }
}