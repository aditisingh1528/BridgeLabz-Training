using System;
using Newtonsoft.Json;

class CarDetails
{
    public string BrandName { get; set; }
    public int ManufacturingYear { get; set; }
}

class CarJson
{
    static void Main(string[] args)
    {
        CarDetails carDetails = new CarDetails();

        Console.WriteLine("Enter car brand:");
        carDetails.BrandName = Console.ReadLine();

        Console.WriteLine("Enter manufacturing year:");
        carDetails.ManufacturingYear = int.Parse(Console.ReadLine());

        //Serializing car object
        string carJson = JsonConvert.SerializeObject(carDetails, Formatting.Indented);

        Console.WriteLine("Car JSON:");
        Console.WriteLine(carJson);
    }
}
