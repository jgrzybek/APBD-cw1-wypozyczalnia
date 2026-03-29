using wypozyczalnia_sprzetu.Models;
using wypozyczalnia_sprzetu.Models.Items;
using wypozyczalnia_sprzetu.Models.Users;

namespace wypozyczalnia_sprzetu.Services.Rentals;

public interface IRentalService
{
    public void CreateRental(User user, Equipment equipment, DateTime startDate, DateTime endDate);
    public void EndRental(int rentalId);
    public List<Rental> getActiveRentals(int userId);
    public List<Rental> getOverdueRentals();
    public List<Tuple<string, int>> getRaport();
}