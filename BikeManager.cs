using System.Text;

namespace BikeRentalManagementSystem_V1;

public class BikeManager
{
    public List<Bike> bikes = new List<Bike>();

    public void CreateBike()
    {
        try
        {
            Console.Write("Enter Bike Id: ");
            string bikeId = Console.ReadLine();
            Console.Write("Enter Bike Brand: ");
            string brand = Console.ReadLine();
            Console.Write("Enter Bike Model: ");
            string model = Console.ReadLine();
            Console.Write("Enter Bike RentalPrice: ");
            decimal rentalPrice = Convert.ToDecimal(Console.ReadLine());

            bikes.Add(new Bike(bikeId, brand, model, rentalPrice));


            Console.WriteLine("\nBike Added Succesfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error occured: {ex.Message}");
        }


    }

    public void ReadBikes()
    {
        try
        {
            Console.WriteLine("++++++++++");
            Console.Write("Available Bikes");
            Console.WriteLine("++++++++++");

            if (bikes.Count != 0)
            {
                foreach (Bike bike in bikes)
                {
                    Console.WriteLine($"{bike.ToString()}");
                }
            }
            else
            {
                Console.WriteLine("\nNo Bikes Available");
            }


        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error Occured: {ex.Message}");
        }
    }

    public void UpdateBike()
    {
        try
        {
            Console.WriteLine("------------");
            Console.Write("Update Bikes");
            Console.WriteLine("------------");

            Console.Write("Enter Bike Id: ");
            string bikeId = Console.ReadLine();

            var bikeData = bikes.Find(b => b.BikeId == bikeId);
            if (bikeData != null)
            {
                Console.Write("Enter New Brand: ");
                string brand = Console.ReadLine();
                Console.Write("Enter New Model");
                string model = Console.ReadLine();
                Console.Write("Enter New Rental Price");
                decimal rentalPrice = decimal.Parse(Console.ReadLine());

                bikeData.BikeId = bikeId;
                bikeData.Brand = brand;
                bikeData.Model = model;
                bikeData.RentalPrice = rentalPrice;

                Console.WriteLine("Bike Updated Successfully");
            }
            else
            {
                Console.WriteLine("Check Your Id");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error Occured: {ex.Message}");
        }
    }

    public void DeleteBike()
    {
        try
        {
            Console.WriteLine("********");
            Console.WriteLine("Delete Bike");
            Console.WriteLine("********");

            Console.Write("Enter Bike Id: ");
            string bikeId = Console.ReadLine();

            var bikeData = bikes.Find(b => b.BikeId == bikeId);
            if (bikeData != null)
            {
                bikes.Remove(bikeData);
                Console.WriteLine("Bike Removed Successfully");
            }
            else
            {
                Console.WriteLine("No Bike Found ! Check the Id Again");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error Occured: {ex.Message}");
        }
    }
}
