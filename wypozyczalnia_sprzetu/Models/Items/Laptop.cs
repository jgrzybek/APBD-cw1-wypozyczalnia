namespace wypozyczalnia_sprzetu.Models.Items;

public class Laptop(string name, double value, double weightInKilograms, Tuple<int, int> screenResolution, float screenSize) : Equipment(name, value, weightInKilograms)
{
    public Tuple<int, int> ScreenResolution { get; set; } = screenResolution;
    public double ScreenSize { get; set; } = screenSize;
}