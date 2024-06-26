using MyEdu.Domain.Core.Entities;
using MyEdu.Domain.Core.Exceptions;

namespace MyEdu.Domain.Core.Tests.Entities;

public class PersonTests
{
    [Fact]
    public void Throws_WhenWhiteSpace()
    {
        Assert.Throws<IllegalNameException>(() =>
        {
            var test = new TestClass(MockData.PositiveInt,
                MockData.WhiteSpace, MockData.String,
                MockData.String, MockData.String,
                MockData.String, MockData.Date,
                [MockData.String], MockData.String);
        });

        Assert.Throws<IllegalDateTimeException>(() =>
        {
            var test = new TestClass(MockData.PositiveInt,
                MockData.WhiteSpace, MockData.String,
                MockData.String, MockData.String,
                MockData.String, DateTimeOffset.Now.AddDays(1),
                [MockData.String], MockData.String);
        });
    }

    private class TestClass(int id, string name, string surname,
        string patronymic, string phone, string address,
        DateTimeOffset birthDate, List<string> images,
        string description)
        : Person<int>(id, name, surname, patronymic, phone, address,
            birthDate, images, description)
    {
        public override int ToDto()
        {
            throw new NotImplementedException();
        }
    }
}