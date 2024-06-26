global using MockData = MyEdu.Domain.Tests.Data;
namespace MyEdu.Domain.Tests;

public static class Data
{
    public static readonly int PositiveInt = 1;
    public static readonly int NegativeInt = -1;
    public static readonly string String = "string";
    public static readonly string WhiteSpace = "    ";
    public static readonly string Name = "Name";
    public static readonly string ImageUrl = "https://my.images.org/images/1";
    public static readonly string Description = "This ain't a description";
    public static readonly DateTimeOffset Date = DateTimeOffset.Parse("20.20.2020");
}

