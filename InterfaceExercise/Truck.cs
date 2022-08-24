using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Truck:IVehicle,ICompany
    {
        public string SizeOfBed {  get; set; }

        public int Horsepower { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int NumberOfWheels { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
    }
}
