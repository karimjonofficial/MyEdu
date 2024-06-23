using Moq;
using MyEdu.Domain.Core.Entities;

namespace MyEdu.Domain.Core.Tests.Entities;

public class PersonTests
{
    [Fact]
    public void ReturnsAge_WhenGivenIsCorrect()
    {
        // Arrange
        var birthdate = new DateTimeOffset(new DateTime(2000, 1, 1));
        var mock = new Mock<Person>(MockBehavior.Strict, 1, "John", "Doe", "Patronymic", "1234567890", "Address", birthdate, "ImageUrl", "Description")
            {
                CallBase = true
            };

        // Act
        var age = mock.Object.GetAge();

        // Assert
        var expectedAge = DateTimeOffset.Now.Year - birthdate.Year;
        Assert.Equal(expectedAge, age);
    }
}