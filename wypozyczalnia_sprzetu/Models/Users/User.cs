using wypozyczalnia_sprzetu.Enums;

namespace wypozyczalnia_sprzetu.Models.Users;

public abstract class User(string name, string surname, UserType userType)
{
    private static int _nextId = 1;
    
    public int Id { get; set; } = _nextId++;
    public string Name { get; set; } = name;
    public string Surname { get; set; } = surname;
    public UserType UserType { get; } = userType;
}