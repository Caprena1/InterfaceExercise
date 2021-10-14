using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public bool SteeringWheel { get; set; }

        public void Drive()
        {
            Console.WriteLine($"I'm driving in my IVehicle");
        }
    }
}
