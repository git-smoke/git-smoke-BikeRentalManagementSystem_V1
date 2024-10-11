﻿namespace BikeRentalManagementSystem_V1;

public class ElectricBike : Bike
{


    public int BatteryCapacity { get; set; }
    public int MotorPower { get; set; }

    public ElectricBike(string bikeId, string brand, string model, decimal rentalPrice, int batterCapacity, int motorPower) : base(bikeId, brand, model, rentalPrice)
    {
        BatteryCapacity = batterCapacity;
        MotorPower = motorPower;
    }

    public string DisplayElectricBikeInfo()
    {
        return $"{base.ToString()}, BatteryCapacity: {BatteryCapacity}, MotorPower: {MotorPower}";
    }
}
