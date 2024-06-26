namespace MyEdu.Domain.Core.DTOs;

public abstract record UserDto<TDto>(int Id, string Name,
    string Surname, string Patronymic, string Phone, string Address,
    DateTimeOffset Birthdate, List<string> Images, string Username,
    string Password, string Description)
    : PersonDto<TDto>(Id, Name, Surname, Patronymic, Phone, Address,
        Birthdate, Images, Description);