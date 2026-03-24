namespace Week8;

public class Percel : DeliveryItem
{
    public string Dimentions { get; private set; }

    public Percel(string trackingNumber, double weight, string dimentions) : base(trackingNumber, weight)
    {
        Dimentions = dimentions;
    }
    public override double CalculateCost()
    {
        return 50 + (Weight * 25);
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Dimensions: {Dimentions}");
    }
}