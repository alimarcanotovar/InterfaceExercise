using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
   class Car:IVehicle, ICompany
    {
        public bool HasTrunk { get; set; }

        public int NumberOfDoors { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int NumberOfWheels { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
    }
}
