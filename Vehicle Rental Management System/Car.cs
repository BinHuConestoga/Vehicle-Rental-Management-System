using System;

namespace Vehicle_Rental_Management_System
{
    public class Car : Vehicle
    {
        public int Seats {  get; set; }
        public string EngineType { get; set; }
        public string Transmission { get; set; }
        public Boolean Convertible { get; set; }
        public Car (string model, string manufacturer, int year, float rentalprice, int seats, string enginetype, string transmission, Boolean convertible) : base (model, manufacturer, year, rentalprice) 
        {
            Model = model;
            Manufacturer = manufacturer;
            Year = year;
            RentalPrice = rentalprice;
            Seats = seats;
            EngineType = enginetype;
            Transmission = transmission;
            Convertible = convertible;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("This vehicle's info:");
            Console.WriteLine("Vehicle Type: Car");
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Manufacturer: " + Manufacturer );
            Console.WriteLine("Year: " + Year );
            Console.WriteLine("Rental Price: " + RentalPrice);
            Console.WriteLine("Seats: " + Seats);
            Console.WriteLine("Engine Type: " + EngineType);
            Console.WriteLine("Transmisssion: " + Transmission);
            Console.WriteLine("Convertible: " + Convertible + "\n");
        }
    }
}
