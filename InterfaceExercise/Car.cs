using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public bool HasTrunk { get; set; }
        public bool HasSunroof { get; set; }

        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public bool SteeringWheel { get; set; }

        public string BusinessName { get; set; }
        public string BusinessLogo { get; set; }

        public void Drive()
        {
            Console.WriteLine($"I'm driving my Car");
        }

          
    }
}
