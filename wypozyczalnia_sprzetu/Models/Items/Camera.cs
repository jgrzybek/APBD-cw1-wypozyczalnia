namespace wypozyczalnia_sprzetu.Models.Items;

public class Camera(string name, double value, double weightInKilograms, Tuple<int, int> resolution, bool hasTripod) : Equipment(name, value, weightInKilograms)
{
    public Tuple<int, int> Resolution { get; set; } = resolution;
    public bool HasTripod { get; set; } = hasTripod;
}