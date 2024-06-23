namespace MyEdu.Domain.Core.DTOs;

public abstract record NamedEntityDto(
    int Id, string Name,
    string ImageUrl,
    string Description) : EntityDto(Id);