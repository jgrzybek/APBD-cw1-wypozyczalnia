using wypozyczalnia_sprzetu.Enums;
using wypozyczalnia_sprzetu.Exceptions;
using wypozyczalnia_sprzetu.Models;
using wypozyczalnia_sprzetu.Models.Items;
using wypozyczalnia_sprzetu.Models.Users;

namespace wypozyczalnia_sprzetu.Services.Rentals;

public class RenralService : IRentalService
{
    private const int MaxStudentRentals = 2, MaxEmployeeRentals = 5;
    private const double DelayFee = 69.99;

    private readonly HashSet<Rental> _rentals = [];
    
    public void Create(User user, Models.Items.Equipment equipment, DateTime startDate, DateTime endDate)
    {
        var activeRentals = getActiveByUser(user).Count;
        if (user.UserType == UserType.Student && activeRentals >= MaxStudentRentals
            || user.UserType == UserType.Employee && activeRentals >= MaxEmployeeRentals)
            throw new TooManyActiveRentalsException(user, activeRentals);
        
        if (equipment.Status == EquipmentStatus.Unavailable)
            throw new EquipmentUnavailableException(equipment.Id);
        
        equipment.Status = EquipmentStatus.Unavailable;
        
        _rentals.Add(new Rental(user, equipment, startDate, endDate));
    }

    public double End(int rentalId,  DateTime endDate) //returns delay fee
    {
        var rental = _rentals.FirstOrDefault(rental => rental.Id == rentalId);
        if (rental is not null)
        {
            rental.EndRental(endDate);
            if (rental.EndDate < endDate)
            {
                return Math.Round((endDate - rental.EndDate).TotalDays * DelayFee, 2);
            }
            
            return 0;
        }
        throw new RentalNotFoundException(rentalId);
    }

    public List<Rental> getActiveByUser(User user)
    {
        return _rentals.Where(rental => rental.IsActive && rental.User == user).ToList();
    }

    public List<Rental> getOverdue()
    {
        return _rentals.Where(rental => rental.IsActive && rental.EndDate < DateTime.Now).ToList();
    }

    public Dictionary<string, int> getRaport()
    {
        return new Dictionary<string, int>
        {
            { "All rentals: ", _rentals.Count },
            { "Active rentals: ", _rentals.Count(rental => rental.IsActive) },
            { "Overdue rentals: ", getOverdue().Count }
        };
    }
}