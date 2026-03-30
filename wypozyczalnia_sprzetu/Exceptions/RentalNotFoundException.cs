namespace wypozyczalnia_sprzetu.Exceptions;

public class RentalNotFoundException(int rentalId) 
    : Exception($"Rental with ID: {rentalId} not found");