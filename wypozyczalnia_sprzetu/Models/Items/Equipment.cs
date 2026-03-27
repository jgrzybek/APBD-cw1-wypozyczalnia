using wypozyczalnia_sprzetu.Enums;

namespace wypozyczalnia_sprzetu.Models.Items;

public abstract class Equipment(string name, double value, double weightInKilograms)
{
    private static int _nextId = 1;
    
    public int Id { get; set; } =  _nextId++;
    public string Name { get; set; } = name;
    public double Value { get; set; } = value;
    public double Weight { get; set; } = weightInKilograms;
    public EquipmentStatus Status { get; set; } = EquipmentStatus.Available;
}