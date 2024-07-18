using System;

namespace Vehicle_Rental_Management_System
{
    /*Add a class Motorcycle which inherits class Vehicle*/
    public class Motorcycle : Vehicle
    {
        /*Add 3 new variables for Motorcycle*/
        public int EngineCapacity { get; set; }
        public string FuelType { get; set; }
        public Boolean HasFairing { get; set; }
        public Motorcycle (string model, string manufacturer, int year, float rentalprice, int engineCapacity, string fuelType, Boolean hasFairing) : base(model, manufacturer, year, rentalprice)
        {
            Model = model;
            Manufacturer = manufacturer;
            Year = year;
            RentalPrice = rentalprice;
            EngineCapacity = engineCapacity;
            FuelType = fuelType;
            HasFairing = hasFairing;
        }

        /*Display all detailed info for the Motorcycle*/
        public override void DisplayDetails()
        {
            Console.WriteLine("This vehicle's info:");
            Console.WriteLine("Vehicle Type: Motorcycle");
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Manufacturer: " + Manufacturer);
            Console.WriteLine("Year: " + Year);
            Console.WriteLine("Rental Price: " + RentalPrice);
            Console.WriteLine("Engine Capacity: " + EngineCapacity);
            Console.WriteLine("Fuel Type: " + FuelType);
            Console.WriteLine("Has Fairing: " + HasFairing + "\n");
        }
    }
}
