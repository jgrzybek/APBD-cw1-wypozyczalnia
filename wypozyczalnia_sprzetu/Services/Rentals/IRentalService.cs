using wypozyczalnia_sprzetu.Models;
using wypozyczalnia_sprzetu.Models.Items;
using wypozyczalnia_sprzetu.Models.Users;

namespace wypozyczalnia_sprzetu.Services.Rentals;

public interface IRentalService
{
    public void Create(User user, Models.Items.Equipment equipment, DateTime startDate, DateTime endDate);
    public double End(int rentalId, DateTime endDate); //returns delay fee
    public List<Rental> getActiveByUser(User user);
    public List<Rental> getOverdue();
    public Dictionary<string, int> getRaport();
}