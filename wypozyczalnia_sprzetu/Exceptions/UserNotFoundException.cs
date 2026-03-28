namespace wypozyczalnia_sprzetu.Exceptions;

public class UserNotFoundException(int userId)
    : Exception($"User with ID: {userId} not found");