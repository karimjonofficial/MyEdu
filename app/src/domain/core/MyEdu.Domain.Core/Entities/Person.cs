namespace MyEdu.Domain.Core.Entities;

public abstract class Person(int id, string name, string surname, string patronymic, string phone,
    string address, DateTimeOffset birthdate, string imageUrl, string description) :
    NamedEntity(id, name, imageUrl, description)
{
    public int GetAge() => DateTimeOffset.Now.Year - birthdate.Year;
}