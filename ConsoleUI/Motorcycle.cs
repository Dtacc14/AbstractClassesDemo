using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public int NumberOfWheels { get; set; }
        public override string DriveAbstract()
        {
            return $"I am a motorcycle! I have {NumberOfWheels} wheels.";
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Zoom!");
        }
    }
}

