namespace BikeRentalManagementSystem_V1
{
    public class Bike
    {

        public string BikeId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal RentalPrice { get; set; }

        public static int TotalBikes { get; set; }

        public Bike(string bikeId, string brand, string model, decimal rentalPrice)
        {
            BikeId = bikeId;
            Brand = brand;
            Model = model;
            RentalPrice = rentalPrice;
            TotalBikes = TotalBikes + 1;
        }


        public override string ToString()
        {
            return $"BikeId : {BikeId}, Brand: {Brand}, Model: {Model}, RentalPrice: {RentalPrice}";
        }

        public virtual string DisplayBikeInfo()
        {
            return ToString();
        }
    }
}


