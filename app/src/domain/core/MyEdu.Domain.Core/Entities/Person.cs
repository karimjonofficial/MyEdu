using MyEdu.Domain.Core.Exceptions;

namespace MyEdu.Domain.Core.Entities;

public abstract class Person<TDto> : PhysicalEntity<TDto>
{
    protected Person(int id, string name, string? surname,
        string? patronymic, string? phone, string? address,
        DateTimeOffset? birthDate, List<string>? images,
        string? description)
        : base(id, images, description)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new IllegalNameException();
        if (birthDate != null && birthDate > DateTimeOffset.Now)
            throw new IllegalDateTimeException();
    }
}