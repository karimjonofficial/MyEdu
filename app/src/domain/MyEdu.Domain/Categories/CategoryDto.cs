using MyEdu.Domain.Core.DTOs;

namespace MyEdu.Domain.Categories;

public record CategoryDto(int Id, string Name, string ImageUrl,
string Description) : NamedEntityDto(Id, Name, ImageUrl, Description);