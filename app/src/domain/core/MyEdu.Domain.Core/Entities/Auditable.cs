using MyEdu.Domain.Core.Exceptions;

namespace MyEdu.Domain.Core.Entities;

public abstract class Auditable<TDto, TPerson> : Entity<TDto>
{
    protected Auditable(int id, DateTimeOffset createdDate, Person<TPerson> createdBy,
        DateTimeOffset modifiedDate, Person<TPerson> modifiedBy) : base(id)
    {
        if (createdDate > DateTimeOffset.Now || modifiedDate > DateTimeOffset.Now)
            throw new IllegalDateTimeException();
    }
}