using MyEdu.Domain.Core.Entities;
using MyEdu.Domain.Core.Interfaces;

namespace MyEdu.Domain.Categories;

public class Category(int id, string name, string imageUrl,
    string description)
    : NamedEntity(id, name, imageUrl, description),
    IEntity<Category, CategoryDto>
{
    private readonly int id = id;
    private readonly string name = name;
    private readonly string imageUrl = imageUrl;
    private readonly string description = description;

    public CategoryDto ToDto()
    {
        return new CategoryDto(id, name, imageUrl, description);
    }

    public static Category FromDto(CategoryDto dto)
    {
        return new Category(dto.Id, dto.Name, dto.ImageUrl,
        dto.Description);
    }
}