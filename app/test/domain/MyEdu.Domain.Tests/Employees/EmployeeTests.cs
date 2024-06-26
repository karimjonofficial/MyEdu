using MyEdu.Domain.Employees;

namespace MyEdu.Domain.Tests.Employees;

public class EmployeeTests
{
    [Fact]
    public void ReturnsDto_BasedOnGiven()
    {
        var employee = new Employee(MockData.PositiveInt,
            MockData.String, MockData.String,
            MockData.String, MockData.String,
            MockData.String, MockData.Date,
            [MockData.String], MockData.String);

        var dto = new EmployeeDto(MockData.PositiveInt,
            MockData.String, MockData.String,
            MockData.String, MockData.String,
            MockData.String, MockData.Date,
            [MockData.String], MockData.String);

        Assert.Equal(employee.ToDto(), dto);
    }
}