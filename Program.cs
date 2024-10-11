using System;

namespace BikeRentalManagementSystem_V1
{
    public class Program
    {
        static void Main(string[] args)
        {

            /*
            Bike bike1 = new Bike("Bike_001", "YAMAHA", "Mt-15", Convert.ToDecimal(10.00));

            Console.WriteLine("******************");
            Console.WriteLine($"{bike1.ToString()}");
            Console.WriteLine("******************");
            */

            BikeManager bikeManager = new BikeManager();
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("+-+-+-+- Bike Rental Management System +-+-+-+-");
                Console.WriteLine("\n1. Add a Bike");
                Console.WriteLine("2. View All Bikes");
                Console.WriteLine("3. Update a Bike");
                Console.WriteLine("4. Delete a Bike");
                Console.WriteLine("5. Exit");
                Console.Write("\nChoose an option: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Clear();
                        bikeManager.CreateBike();
                        break;
                    case "2":
                        Console.Clear();
                        bikeManager.ReadBikes();
                        break;
                    case "3":
                        Console.Clear();
                        bikeManager.UpdateBike();
                        break;
                    case "4":
                        Console.Clear();
                        bikeManager.DeleteBike();
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Choose the Correct Option");
                        break;
                }
                if (!exit)
                {
                    Console.WriteLine("Press Enter to Continue....");
                    Console.ReadLine();
                }
            }
        }
    }
}