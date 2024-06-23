namespace MyEdu.Domain.Core.DTOs;

public abstract record PersonDto(
    int Id,
    string Name,
    string Surname,
    string Patronymic,
    string Phone,
    string Address,
    DateTimeOffset Birthdate,
    string ImageUrl,
    string Description) : NamedEntityDto(Id, Name, ImageUrl, Description);