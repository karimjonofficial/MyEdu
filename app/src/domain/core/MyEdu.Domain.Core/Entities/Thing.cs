using MyEdu.Domain.Core.Exceptions;

namespace MyEdu.Domain.Core.Entities;

public abstract class Thing<TDto> : PhysicalEntity<TDto>
{
    protected Thing(int id, string name, List<string> images,
        string description)
        : base(id, images, description)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new IllegalNameException();
    }
}