using System;
using System.Collections.Generic;

interface IInsurable
{
    double CalculateInsurance();
    string GetInsuranceDetails();
}

abstract class Vehicle
{
    private string vehicleNumber;
    protected double rentalRate;

    protected Vehicle(string number, double rate)
    {
        vehicleNumber = number;
        rentalRate = rate;
    }

    public abstract double CalculateRentalCost(int days);
}

class Car : Vehicle, IInsurable
{
    public Car(string number, double rate) : base(number, rate) { }
    public override double CalculateRentalCost(int days) => rentalRate * days;
    public double CalculateInsurance() => 500;
    public string GetInsuranceDetails() => "Car Insurance";
}

class Bike : Vehicle
{
    public Bike(string number, double rate) : base(number, rate) { }
    public override double CalculateRentalCost(int days) => rentalRate * days;
}
