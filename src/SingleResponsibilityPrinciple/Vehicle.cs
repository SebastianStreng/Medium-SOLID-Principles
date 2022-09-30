public class Vehicle
{
    public Vehicle(string type, int size, int axles, double moutPerKilometer)
    {
        this.type = type;
        this.size = size;
        this.axles = axles;
        this.moutPerKilometer = moutPerKilometer;
    }

    public string type { get; set; }
    public int size { get; }
    public int axles { get; }
    public double moutPerKilometer { get; set; }
}
