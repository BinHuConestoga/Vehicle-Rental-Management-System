using System;

namespace Vehicle_Rental_Management_System
{
    /*Add a class Car which inherits class Vehicle*/
    public class Car : Vehicle
    {
        /*Add 4 new variables for Car*/
        public int Seats {  get; set; }
        public string EngineType { get; set; }
        public string Transmission { get; set; }
        public Boolean Convertible { get; set; }
        public Car (string model, string manufacturer, int year, float rentalPrice, int seats, string engineType, string transmission, Boolean convertible) : base (model, manufacturer, year, rentalprice) 
        {
            Model = model;
            Manufacturer = manufacturer;
            Year = year;
            RentalPrice = rentalPrice;
            Seats = seats;
            EngineType = engineType;
            Transmission = transmission;
            Convertible = convertible;
        }

        /*Display all detailed info for the Car*/
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
