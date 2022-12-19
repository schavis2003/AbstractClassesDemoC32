using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle  // I created an Abstract class called Vehicle----DONE
    {
        //I created 3 sting properties for the class = Vehicle called Year, Make and Model below.----DONE
        public int Year { get; set; } = 1;  // I set generic defaults in the Class call Vehicle for the 3 properties below.----DONE
        public string Make { get; set; } = "Default Make";
        public string Model { get; set; } = "Default Model";

        internal static void Add(Car focus)
        {
            throw new NotImplementedException();
        }

        internal static void Add(Motorcycle motorcycle)
        {
            throw new NotImplementedException();
        }

        internal static void Add(Vehicle sedan)
        {
            throw new NotImplementedException();
        }

        public abstract void DriveAbstract(); // I created an abstract method call DriveAbstract with no implementatioin. This is called "stubbed out method"---DONE

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name}  is virtually in drive"); // I crerated Virtual method Call DriveVirtual with a base implemantion. -----DONE
        }
    }
}
