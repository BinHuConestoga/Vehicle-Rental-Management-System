namespace Vehicle_Rental_Management_System
{
    /*Create an abstract class Vehicle with abstract method DisplayDetails*/
    public abstract class Vehicle
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public float RentalPrice { get; set; }

        public Vehicle (string model, string manufacturer, int year, float rentalPrice)
        { 
            Model = model;
            Manufacturer = manufacturer;
            Year = year;
            RentalPrice = rentalPrice;
        }

        public abstract void DisplayDetails();

    }
}
