using wypozyczalnia_sprzetu.Enums;
using wypozyczalnia_sprzetu.Exceptions;
using wypozyczalnia_sprzetu.Models.Items;
using wypozyczalnia_sprzetu.Models.Users;
using wypozyczalnia_sprzetu.Services.Equipment;
using wypozyczalnia_sprzetu.Services.Rentals;

var equipmentService = new EquipmentService();
var rentalService = new RenralService();
var users = new List<User>();

//Dodanie sprzętu
var item1 = new Camera("Nikon D90", 900, 0.9, new Tuple<int, int>(1920, 1080), true);
equipmentService.Add(item1);
equipmentService.Add(new Laptop("Asus", 5999.99, 2, new Tuple<int, int>(1920, 1080), 15));
equipmentService.Add(new Projector("Sony", 6000, 5, 400, SpaceType.LivingRoom));

//Dodanie użytkowników
users.Add(new Professor("Adam", "Kowalski", "Systemy systemów systemowych"));
users.Add(new StudentIT("Marcin", "Dzwon", 2));
users.Add(new StudentIT("Adrianna", "Kometa", 5));

//poprawne wypożyczenie
rentalService.Create(users[2], equipmentService.GetAvailable().First(e => e.Name == "Asus"), new DateTime(2020, 1, 1), new DateTime(2020, 1, 3));

//przekroczony limit
rentalService.Create(users[2], equipmentService.GetAvailable().First(e => e.Name == "Nikon D90"), new DateTime(2020, 1, 1), new DateTime(2020, 1, 3));
try
{
    rentalService.Create(users[2], equipmentService.GetAvailable().First(e => e.Name == "Sony"), new DateTime(2020, 1, 1), new DateTime(2020, 1, 3));
}
catch (Exception e)
{
    Console.WriteLine(e);
}

//wypożyczenie niedostępnego sprzętu
try
{
    rentalService.Create(users[1], item1, new DateTime(2020, 1, 1), new DateTime(2020, 1, 3));
}
catch (Exception e)
{
    Console.WriteLine(e);
}

//zwrot w terminie
rentalService.End(rentalService.getActiveByUser(users[2]).First().Id, new DateTime(2020, 1, 2));

//zwrot opóźniony
Console.Write("Naliczona kara za przekroczenie czasu: ");
Console.Write(rentalService.End(rentalService.getActiveByUser(users[2]).First().Id, new DateTime(2020, 1, 6)));
Console.Write("zł\n");

foreach (var raportLine in rentalService.getRaport())
{
    Console.WriteLine(raportLine);
}