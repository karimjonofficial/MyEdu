using MyEdu.Domain.Core.Entities;
using MyEdu.Domain.Core.Exceptions;

namespace MyEdu.Domain.Core.Tests.Entities;

public class EntityTests
{

    [Fact]
    public void ThrowsException_WhenNegativeId()
    {
        Assert.Throws<IllegalIdException>(() =>
        {
            var entity = new TestEntity(MockData.NegativeInt);
        });
    }

    private class TestEntity(int id) : Entity<int>(id)
    {
        public override int ToDto()
        {
            throw new NotImplementedException();
        }
    }
}