using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public bool FourWheelDrive { get; set; }
        public int Cargo { get; set; }

        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public bool SteeringWheel { get; set; }

        public string BusinessName { get; set; }
        public string BusinessLogo { get; set; }

        public void Drive()
        {
            Console.WriteLine($"I am driving my SUV");
        }

    }
}
