namespace BikeRentalManagementSystem_V1
{
    public class Bike
    {

        private string BikeId { get; set; }
        private string Brand { get; set; }
        private string Model { get; set; }
        private decimal RentalPrice { get; set; }

        public Bike(string bikeId, string brand, string model, decimal rentalPrice)
        {
            BikeId = bikeId;
            Brand = brand;
            Model = model;
            RentalPrice = rentalPrice;
        }

        public override string ToString()
        {
            return $"BikeId : {BikeId}, Brand: {Brand}, Model: {Model}, RentalPrice: {RentalPrice}";
        }
    }
}


