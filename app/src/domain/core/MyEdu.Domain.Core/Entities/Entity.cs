using MyEdu.Domain.Core.Exceptions;

namespace MyEdu.Domain.Core.Entities;

public abstract class Entity<TDto>
{
    protected Entity(int id)
    {
        if(id < 0) throw new IllegalIdException();
    }
    public abstract TDto ToDto();
}