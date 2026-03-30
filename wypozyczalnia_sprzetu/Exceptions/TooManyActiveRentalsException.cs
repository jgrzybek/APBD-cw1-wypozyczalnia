using wypozyczalnia_sprzetu.Models.Users;

namespace wypozyczalnia_sprzetu.Exceptions;

public class TooManyActiveRentalsException(User user, int numberOfActiveRentals)
    : Exception($"User {user.Name} {user.Surname} - ID: {user.Id} reached the limit of active rentals - {numberOfActiveRentals}");