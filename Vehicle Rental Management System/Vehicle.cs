namespace Vehicle_Rental_Management_System
{
    /*    Create an abstract class Vehicle with abstract method DisplayDetails*/
    abstract public class Vehicle
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public float RentalPrice { get; set; }

        public Vehicle (string model, string manufacturer, int year, float rentalprice)
        { 
            Model = model;
            Manufacturer = manufacturer;
            Year = year;
            RentalPrice = rentalprice;
        }

        public abstract void DisplayDetails();

    }
}
