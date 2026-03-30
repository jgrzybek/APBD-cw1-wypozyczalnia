using wypozyczalnia_sprzetu.Enums;

namespace wypozyczalnia_sprzetu.Models.Items;

public class Projector(string name, double value, double weightInKilograms, int powerDraw, SpaceType intendedSpace) : Equipment(name, value, weightInKilograms)
{
    public int PowerDraw { get; set; } = powerDraw;
    public SpaceType SpaceType { get; set; } = intendedSpace;
}