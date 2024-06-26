namespace MyEdu.Domain.Core.DTOs;

public abstract record PhysicalDto<TEntity>(int Id,
    List<string> Images, string Description) : Dto<TEntity>(Id);