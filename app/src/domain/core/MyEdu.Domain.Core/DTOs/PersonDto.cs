namespace MyEdu.Domain.Core.DTOs;

public abstract record PersonDto<TEntity>(int Id, string Name,
    string Surname, string Patronymic, string Phone, string Address,
    DateTimeOffset Birthdate, List<string> Images, string Description)
    : PhysicalDto<TEntity>(Id, Images, Description);