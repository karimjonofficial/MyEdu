namespace MyEdu.Domain.Core.DTOs;

public abstract record AuditableDto<TEntity, TPerson>(
    int Id,
    DateTimeOffset CreatedDate, PersonDto<TPerson> CreatedBy,
    DateTimeOffset ModifiedDate, PersonDto<TPerson> ModifiedBy) :
    Dto<TEntity>(Id);