using MyEdu.Domain.Core.DTOs;

namespace MyEdu.Domain.Employees;

public record EmployeeDto(int Id, string Name, string Surname,
    string Patronymic, string Phone, string Address,
    DateTimeOffset Birthdate, List<string> Images, string Description)
    : PersonDto<Employee>(Id, Name, Surname, Patronymic, Phone,
        Address, Birthdate, Images, Description)
{
    public override Employee ToEntity()
    {
        throw new NotImplementedException();
    }
}