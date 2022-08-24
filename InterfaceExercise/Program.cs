using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var bmw = new Car() {HasTrunk = true, Logo = "car go beep beep", Make = "crappy", Model = "A to B", Name = "Poop", NumberOfDoors = 4, NumberOfWheels = 4, Year = 1973, };

           

            var ford = new Truck() { Horsepower = 1000 , Logo = "perfect for little man syndrome", Make = "pooper", Model = "nasty ", Name = "fragile ego", NumberOfWheels = 4, SizeOfBed = " UUUgge", Year = 2000};

        

            var suv1 = new Suv() { CargoHoldSize = "Alot", Logo = "I am a suv", Make = " carmaker", Model = " mom van", Name = "soccer mom 9000", NumberOfSeats = 100 , NumberOfWheels = 4, Year = 3000, };


            var list = new List<IVehicle>();
            list.Add(ford);
            list.Add(suv1);
            list.Add(bmw);


            var list1 = new List<ICompany>();
            list1.Add(ford);
            list1.Add(suv1);
            list1.Add(bmw);

            foreach (var item in list)
            {
                Console.WriteLine($"this is the foreach item from orginal list {item.Year}, {item.Make}, {item.Model}, {item.NumberOfWheels}");
               
            }
            
            

            foreach (var item in list1)
            {
                Console.WriteLine($"this is the foreach line for list1 I am DIFFERENT {item.Logo}, {item.Name}");

            }



            Console.WriteLine($"console writeline for car {bmw.HasTrunk}, {bmw.NumberOfDoors}");

            Console.WriteLine($"console writeline for truck {ford.NumberOfWheels}, {ford.Horsepower}");

            Console.WriteLine($"console writeline for suv1 {suv1.CargoHoldSize},{suv1.NumberOfSeats}");

                //Now, create objects of your 3 classes and give their members values;
                //Creatively display and organize their values
        }


    }
}
