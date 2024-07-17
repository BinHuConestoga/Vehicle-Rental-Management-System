using System;
using System.Collections.Generic;

namespace Vehicle_Rental_Management_System
{
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
            fleet.Add(v);
            Console.WriteLine("One vehicle is removed from the fleet\n");
        }

        public void RentVehicle(Vehicle v)
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
            Vehicle v1 = new Car("Model1", "Manufacturer1", 1999, 120, 4, "Engine1", "trans1", true);
            Vehicle v2 = new Truck("Model2", "Manufacturer2", 2001, 150, 2, "TruckType1", false);
            Vehicle v3 = new Motorcycle("Model3", "Manufacturer3", 2024, 80, 6, "FuelType2", true);


            RentalAgency rentalAgency = new RentalAgency();

            rentalAgency.AddVehicle(v1);
            v1.DisplayDetails();
            rentalAgency.AddVehicle(v2);
            v2.DisplayDetails();
            rentalAgency.AddVehicle(v3);
            v3.DisplayDetails();

            rentalAgency.RentVehicle(v1);
            rentalAgency.RentVehicle(v2);
            rentalAgency.RentVehicle(v3);

            rentalAgency.RemoveVehicle(v1);
            rentalAgency.RemoveVehicle(v2);
            rentalAgency.RemoveVehicle(v3);

            rentalAgency.ShowTotalRevenue();


        }
    }
}
