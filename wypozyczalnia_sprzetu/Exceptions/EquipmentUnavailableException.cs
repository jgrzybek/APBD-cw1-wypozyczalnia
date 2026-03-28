namespace wypozyczalnia_sprzetu.Exceptions;

public class EquipmentUnavailableException(int itemId) 
    : Exception($"Equipment with ID: {itemId} is unavailable");