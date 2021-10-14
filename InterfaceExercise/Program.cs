using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            var myCar = new Car { Make = "Honda", Model = "Accord", Color = "Red", HasTrunk = true, HasSunroof = true };
            var myTruck = new Truck { Make = "Ford", Model = "Ranger", Color = "Black", TruckBed = true, TruckCab = true };
            var mySUV = new SUV { Make = "Kia", Model = "Telluride", Color = "White", FourWheelDrive = false, Cargo = 70 };

            var vehicles = new List<IVehicle>();


            vehicles.Add(myCar);
            vehicles.Add(myTruck);
            vehicles.Add(mySUV);

            Console.WriteLine("Looping through the Vehicles List");
            Console.WriteLine("============================");

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Make: {vehicle.Make} Model: {vehicle.Model} Color: {vehicle.Color}");
                Console.WriteLine(vehicle);

            }
        }
    }

}



            
    

    

        //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

        //Create 2 Interfaces called IVehicle & ICompany - DONE

        //Create 3 classes called Car , Truck , & SUV - DONE

        //In your IVehicle

        /* Create 4 members that Car, Truck, & SUV all have in common.
         * Example: All vehicles have a number of wheels... for now..
         */


        //In ICompany

        /*Create 2 members that are specific to each every company
         * regardless of vehicle type.
         *
         *
         * Example: public string Logo { get; set; }
         */

        //In each of your car, truck, and suv classes

        /*Create 2 members that are specific to each class
         * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
         *
     }    * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
         * 
         */

        //Now, create objects of your 3 classes and give their members values;
        //Creatively display and organize their values
    
    

