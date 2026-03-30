using wypozyczalnia_sprzetu.Enums;

namespace wypozyczalnia_sprzetu.Services.Equipment;
using wypozyczalnia_sprzetu.Models.Items;

public interface IEquipmentService
{
    public void Add(Equipment equipment);
    public Dictionary<Equipment, EquipmentStatus> GetAllWithStatus();
    public List<Equipment> GetAvailable();
    public void SetUnavailable(Equipment equipment);
    
}