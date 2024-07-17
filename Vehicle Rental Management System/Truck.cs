using System;

namespace Vehicle_Rental_Management_System
{
    public class Truck : Vehicle
    {
        public int Capacity { get; set; }
        public string TruckType { get; set; }
        public Boolean FourWheelDrive { get; set; }
        public Truck(string model, string manufacturer, int year, float rentalprice, int capacity, string truckType, Boolean fourWheelDrive) : base(model, manufacturer, year, rentalprice)
        {
            Model = model;
            Manufacturer = manufacturer;
            Year = year;
            RentalPrice = rentalprice;
            Capacity = capacity;
            TruckType = truckType;
            FourWheelDrive = fourWheelDrive;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("This vehicle's info:");
            Console.WriteLine("Vehicle Type: Truck");
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Manufacturer: " + Manufacturer);
            Console.WriteLine("Year: " + Year);
            Console.WriteLine("Rental Price: " + RentalPrice);
            Console.WriteLine("Capacity: " + Capacity);
            Console.WriteLine("Truck Type: " + TruckType);
            Console.WriteLine("Four Wheel Drive: " + FourWheelDrive + "\n");
        }
    }
}
