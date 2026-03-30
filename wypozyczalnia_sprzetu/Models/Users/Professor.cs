using wypozyczalnia_sprzetu.Enums;

namespace wypozyczalnia_sprzetu.Models.Users;

public class Professor(string name, string surname, string specialisation) : User(name, surname, Type)
{
    private const UserType Type = UserType.Employee;
    public string Specialisation {get; set;} =  specialisation;
}