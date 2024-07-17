using System;

namespace Vehicle_Rental_Management_System
{
    public class Motorcycle : Vehicle
    {
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
