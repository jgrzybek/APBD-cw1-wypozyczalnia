using wypozyczalnia_sprzetu.Models.Items;
using wypozyczalnia_sprzetu.Models.Users;

namespace wypozyczalnia_sprzetu.Models;

public class Rental(User user, Equipment equipment, DateTime startDate, DateTime endDate)
{
    private static int _nextId = 1;
    
    public int Id { get; set; } = _nextId++;
    public User User { get; set; } = user;
    public Equipment Equipment { get; set; } = equipment;
    public DateTime StartDate { get; set; } = startDate;
    public DateTime EndDate { get; set; } = endDate;
    public DateTime? ReturnedDate { get; set; } = null;
    public bool IsActive { get; set; } = true;
}