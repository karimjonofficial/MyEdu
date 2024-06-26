namespace MyEdu.Domain.Core.DTOs;

public abstract record ThingDto<TEntity>(int Id, string Name,
    List<string> Images, string Description)
    : PhysicalDto<TEntity>(Id, Images, Description);