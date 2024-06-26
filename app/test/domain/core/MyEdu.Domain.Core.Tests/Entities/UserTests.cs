using MyEdu.Domain.Core.Entities;
using MyEdu.Domain.Core.Exceptions;

namespace MyEdu.Domain.Core.Tests.Entities;

public class UserTests
{
    [Fact]
    public void Throws_WhenIllegalUsernameOrPassword()
    {
        Assert.Throws<IllegalUsernameException>(() =>
        {
            var test = new TestClass(MockData.PositiveInt,
                MockData.String, MockData.String,
                MockData.String, MockData.String,
                MockData.String, MockData.Date,
                [MockData.String], MockData.WhiteSpace,
                MockData.String, MockData.String);
        });
        Assert.Throws<IllegalPasswordException>(() =>
        {
            var test = new TestClass(MockData.PositiveInt,
                MockData.String, MockData.String,
                MockData.String, MockData.String,
                MockData.String, MockData.Date,
                [MockData.String], MockData.String,
                MockData.WhiteSpace, MockData.String);
        });
    }

    private class TestClass(int id, string name, string surname,
        string patronymic, string phone, string address,
        DateTimeOffset birhtDate, List<string> images,
        string username, string password, string description)
        : User<int>(id, name, surname, patronymic, phone, address,
            birhtDate, images, username, password, description)
    {
        public override int ToDto()
        {
            throw new NotImplementedException();
        }
    }
}