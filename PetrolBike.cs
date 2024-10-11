namespace BikeRentalManagementSystem_V1;

public class PetrolBike : Bike
{
    public int FuelTankCapacity { get; set; }
    public int EngineCapacity { get; set; }
    public PetrolBike(string bikeId, string brand, string model, decimal rentalPrice, int fuelTankCapacity, int engineCapacity) : base(bikeId, brand, model, rentalPrice)
    {
        EngineCapacity = engineCapacity;
        FuelTankCapacity = fuelTankCapacity;
    }


}
