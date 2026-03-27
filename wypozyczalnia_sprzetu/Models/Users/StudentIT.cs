using wypozyczalnia_sprzetu.Enums;

namespace wypozyczalnia_sprzetu.Models.Users;

public class StudentIT(string name, string surname, int semester) : User(name, surname, Type)
{
    private const UserType Type = UserType.Employee;
    public int Semester { get; set; } = semester;
}