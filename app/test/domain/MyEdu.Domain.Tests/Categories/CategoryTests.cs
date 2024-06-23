using MyEdu.Domain.Categories;
namespace MyEdu.Domain.Tests;

public class CategoryTests
{
    private const int Id = 1;
    private const string Name = "Category";
    private const string ImageUrl = "https://my.images.org/images/1";
    private const string Description = "This ain't a description";

    [Fact]
    public void ReturnsDto_EqualsToClass()
    {
        var category = new Category(Id, Name,
        ImageUrl, Description);
        var dto = category.ToDto();
        var categoryDto = new CategoryDto(Id, Name, ImageUrl,
        Description);
    }
}
