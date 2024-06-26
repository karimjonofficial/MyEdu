using MyEdu.Domain.Core.Entities;
using MyEdu.Domain.Core.Exceptions;

namespace MyEdu.Domain.Core.Tests.Entities;

public class ThingTests
{
    [Fact]
    public void Throws_WhenEmptyName()
    {
        Assert.Throws<IllegalNameException>(() =>
        {
            var test = new TestClass(MockData.PositiveInt, 
                MockData.WhiteSpace, [MockData.String],
                MockData.String);
        });
    }

    private class TestClass(int id, string name,
        List<string> images, string description)
        : Thing<int>(id, name, images, description)
    {
        public override int ToDto()
        {
            throw new NotImplementedException();
        }
    }
}