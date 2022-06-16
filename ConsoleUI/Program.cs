using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Todo follow all comments!! 

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            List<Vehicle> vehicles = new List<Vehicle>(); // Create a list of Vehicle called vehicles

            var kia = new Car() { Year = 2021, Make = "Kia", Model = "Rio", NumberOfWheels = 4 };
            var harley = new Motorcycle() { Year = 2022, Make = "Harley Davidson", Model = "Road King", NumberOfWheels = 2 };  // Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
            Vehicle toyota = new Car() { Year = 2003, Make = "Toyota", Model = "Solara", NumberOfWheels = 4 };                  // - new it up as one of each derived class
            Vehicle janus = new Motorcycle() { Year = 2019, Make = "Janus", Model = "Halcyon 450", NumberOfWheels = 2 };       // Set the properties with object initializer syntax

            vehicles.Add(kia);
            vehicles.Add(harley);
            vehicles.Add(janus);
            vehicles.Add(toyota);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"This is a {vehicle.Year} {vehicle.Make} {vehicle.Model}.");
                Console.WriteLine();
            }

            Console.WriteLine($"Message from the Toyota: {kia.DriveAbstract()}");
            Console.Write("The Kia says: ");
            kia.DriveVirtual();                                                              // Add the 4 vehicles to the list
            Console.WriteLine();                                                                // Using a foreach loop iterate over each of the properties 
            Console.WriteLine($"Message from the Harley Davidson: {harley.DriveAbstract()}");
            Console.Write("The Harley Davidson says: ");                                        // Call each of the drive methods for one car and one motorcycle
            harley.DriveVirtual();

            #endregion
            Console.ReadLine();
        }
    }
}
