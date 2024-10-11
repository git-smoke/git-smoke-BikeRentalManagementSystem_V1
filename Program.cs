using System;

namespace BikeRentalManagementSystem_V1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bike bike1 = new Bike("Bike_001", "YAMAHA", "Mt-15", Convert.ToDecimal(10.00));

            Console.WriteLine("******************");
            Console.WriteLine($"{bike1.ToString()}");
            Console.WriteLine("******************");
        }
    }
}