using MyEdu.Domain.Core.Exceptions;

namespace MyEdu.Domain.Core.Entities;

public abstract class User<TDto> : Person<TDto>
{
    protected User(int id, string name, string surname,
        string patronymic, string phone, string address,
        DateTimeOffset birthDate, List<string> images,
        string username, string password, string description)
        : base(id, name, surname, patronymic, phone, address,
            birthDate, images, description)
    {
        if (string.IsNullOrWhiteSpace(username))
            throw new IllegalUsernameException();
        if(string.IsNullOrWhiteSpace(password))
            throw new IllegalPasswordException();
    }
}