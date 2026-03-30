using wypozyczalnia_sprzetu.Models;
using wypozyczalnia_sprzetu.Models.Items;
using wypozyczalnia_sprzetu.Models.Users;

namespace wypozyczalnia_sprzetu.Services.Rentals;

public interface IRentalService
{
    public void CreateRental(User user, Equipment equipment, DateTime startDate, DateTime endDate);
    public double EndRental(int rentalId, DateTime endDate); //returns delay fee
    public List<Rental> getActiveRentalsUser(User user);
    public List<Rental> getOverdueRentals();
    public Dictionary<string, int> getRaport();
}