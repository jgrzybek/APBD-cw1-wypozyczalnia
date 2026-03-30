using wypozyczalnia_sprzetu.Enums;

namespace wypozyczalnia_sprzetu.Services.Equipment;
using wypozyczalnia_sprzetu.Models.Items;

public class EquipmentService : IEquipmentService
{
    private readonly HashSet<Equipment> _equipments = [];
    
    public void Add(Equipment equipment)
    {
        _equipments.Add(equipment);
    }

    public Dictionary<Equipment, EquipmentStatus> GetAllWithStatus()
    {
        var result = new Dictionary<Equipment, EquipmentStatus>();
        foreach (var equipment in _equipments)
        {
            result.Add(equipment, equipment.Status);
        }
        return result;
    }

    public List<Equipment> GetAvailable()
    {
        return _equipments.Where(equipment => equipment.Status == EquipmentStatus.Available).ToList();
    }

    public void SetUnavailable(Equipment equipment)
    {
        equipment.Status = EquipmentStatus.Unavailable;
    }
}