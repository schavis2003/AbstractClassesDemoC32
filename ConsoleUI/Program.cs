using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        private static IEnumerable<object> vehicle;

        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles



            // Create a list of Vehicle called vehicles-----Done
          
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - set them up as one of each derived class
             * Set the properties with object initializer syntax
             */

            var focus = new Car() { HasTrunk = true, Make = "Range Rover", Model = "Autobiography", Year = 2023 }; //------DONE
            var motorcycle = new Motorcycle() { HasSideCart = true, Make = "BMW", Model = "350i", Year = 2017 };//-----DONE

            Vehicle sedan = new Car() { Make = "GMC", Model = "Denali", Year = 2005 };
            Vehicle sport = new Car() { HasTrunk = false, Make = "Can Am", Model = "900", Year = 2025 };
            
            
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            vehicles.Add(focus);
            vehicles.Add(motorcycle);
            vehicles.Add(sedan);
            vehicles.Add(sport);

            foreach (var veh in vehicles)
            {
                Console.WriteLine($"Make  {veh.Make}  Model  {veh.Model}  Year  {veh.Year}"); // HELP -- I'm not sure how to fix this error message!!! I think the problem is 
                // within private static IEnumerable<object> vehicle;   OR because I don't have a "throw new NotImplementedException();" statement in Vehicle class. 
                veh.DriveVirtual();
                Console.WriteLine();
                
            }

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
