namespace wypozyczalnia_sprzetu.Exceptions;

public class EquipmentNotFoundException(int equipmentId)
    : Exception($"Equipment with ID: {equipmentId} not found");