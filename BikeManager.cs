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
            decimal rentalPrice = ValidateRentalPrice();

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
            Console.WriteLine("Available Bikes");
            Console.WriteLine("++++++++++");

            if (bikes.Count != 0)
            {
                foreach (Bike bike in bikes)
                {
                    Console.WriteLine($"\n{bike.ToString()}");
                }
            }
            else
            {
                Console.WriteLine("\nNo Bikes Available");
            }


        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nError Occured: {ex.Message}");
        }
    }

    public void UpdateBike()
    {
        try
        {
            Console.WriteLine("------------");
            Console.WriteLine("Update Bikes");
            Console.WriteLine("------------");

            Console.Write("\nEnter Bike Id: ");
            string bikeId = Console.ReadLine();

            var bikeData = bikes.Find(b => b.BikeId == bikeId);
            if (bikeData != null)
            {
                Console.Write("Enter New Brand: ");
                string brand = Console.ReadLine();
                Console.Write("Enter New Model");
                string model = Console.ReadLine();
                Console.Write("Enter New Rental Price");
                decimal rentalPrice = ValidateRentalPrice();

                bikeData.BikeId = bikeId;
                bikeData.Brand = brand;
                bikeData.Model = model;
                bikeData.RentalPrice = rentalPrice;

                Console.WriteLine("\nBike Updated Successfully");
            }
            else
            {
                Console.WriteLine("\nCheck Your Id");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nError Occured: {ex.Message}");
        }
    }

    public void DeleteBike()
    {
        try
        {
            Console.WriteLine("********");
            Console.WriteLine("Delete Bike");
            Console.WriteLine("********");

            Console.Write("\nEnter Bike Id: ");
            string bikeId = Console.ReadLine();

            var bikeData = bikes.Find(b => b.BikeId == bikeId);
            if (bikeData != null)
            {
                bikes.Remove(bikeData);
                Console.WriteLine("\nBike Removed Successfully");
            }
            else
            {
                Console.WriteLine("\nNo Bike Found ! Check the Id Again");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nError Occured: {ex.Message}");
        }
    }

    public decimal ValidateRentalPrice()
    {
        decimal rentalPrice = 0;

        try
        {
            while (true)
            {
                Console.Write("Enter the rental Price: ");
                decimal price = decimal.Parse(Console.ReadLine());

                if (price > 0)
                {
                    rentalPrice = price;

                }
                else
                {
                    //rentalPrice = price * -1;
                    Console.WriteLine("Please Enter a Positive amount");
                }
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error Occured: {ex.Message}");
        }

        return rentalPrice;
    }
}
