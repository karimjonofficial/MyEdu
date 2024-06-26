namespace MyEdu.Domain.Core.Entities;

public abstract class PhysicalEntity<TDto>(int id,
    List<string>? images, string? description) : Entity<TDto>(id);