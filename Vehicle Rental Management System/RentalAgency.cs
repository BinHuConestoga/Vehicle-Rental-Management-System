using System;
using System.Collections.Generic;

namespace Vehicle_Rental_Management_System
{
    /*Add class to add/remove vehicles and calculate the total revenue of the agency*/
    public class RentalAgency
    {
        private List<Vehicle> fleet;
        public float TotalRevenue;

        public RentalAgency()
        {
            fleet = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle v)
        {
            fleet.Add(v);
            Console.WriteLine("One vehicle is added from the fleet\n");
        }

        public void RemoveVehicle(Vehicle v)
        {
            fleet.Remove(v);
            Console.WriteLine("One vehicle is removed from the fleet\n");
        }

        public void CalculateRevenue(Vehicle v)
        {
            TotalRevenue += v.RentalPrice;
        }

        public void ShowTotalRevenue()
        {
            Console.WriteLine("The Total Revenue is: " + TotalRevenue);
        }

    }


    public class Assignment3
    {
        static void Main(String[] arg)
        {
            /*instantiate 3 vehicles including Car, Truck and Motorcycle*/
            Vehicle v1 = new Car("Model1", "Manufacturer1", 1999, 120, 4, "Engine1", "trans1", true);
            Vehicle v2 = new Truck("Model2", "Manufacturer2", 2001, 150, 2, "TruckType1", false);
            Vehicle v3 = new Motorcycle("Model3", "Manufacturer3", 2024, 80, 6, "FuelType2", true);

            /*instantiate RentalAgency*/
            RentalAgency rentalAgency = new RentalAgency();

            /*Add the 3 vehicles to the fleet*/
            rentalAgency.AddVehicle(v1);
            v1.DisplayDetails();
            rentalAgency.AddVehicle(v2);
            v2.DisplayDetails();
            rentalAgency.AddVehicle(v3);
            v3.DisplayDetails();

            /*Rent the 3 vehicles and calculate the rental avenue*/
            rentalAgency.CalculateRevenue(v1);
            rentalAgency.CalculateRevenue(v2);
            rentalAgency.CalculateRevenue(v3);

            /*Remove the 3 vehicles from the fleet*/
            rentalAgency.RemoveVehicle(v1);
            rentalAgency.RemoveVehicle(v2);
            rentalAgency.RemoveVehicle(v3);

            /*Show the total revenue of the rental*/
            rentalAgency.ShowTotalRevenue();


        }
    }
}
