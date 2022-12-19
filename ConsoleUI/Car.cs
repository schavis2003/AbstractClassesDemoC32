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

        public bool HasTrunk { get; set; } = true; // I added a district property in th e2 derived classes called HasTrunk for Car and HasSideCart for Motorcycle below.---DONE

        public bool HasSideCart { get; set; } = true;

        public override void DriveAbstract()
        {
            Console.WriteLine("This Car is in drive");
        }

        
    }
}
