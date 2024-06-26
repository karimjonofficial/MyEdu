using MyEdu.Domain.Core.Entities;

namespace MyEdu.Domain.Employees;

public class Employee(int id, string name, string surname,
    string patronymic, string phone, string address, 
    DateTimeOffset birthDate, List<string>? images,
    string? description)
    : Person<EmployeeDto>(id, name, surname, patronymic,
        phone, address, birthDate, images, description)
{
    public override EmployeeDto ToDto()
    {
        return new EmployeeDto(id, name, surname, patronymic,
            phone, address, birthDate, images, description);
    }
}