using LaboratorioDeTestes.Entities;
using Xunit;

namespace LaboratorioDeTestes.Tests.Entities;

public sealed class CarTests
{
    [Fact]
    public void Constructor_GivenAllParameters_ThenShouldSetThePropertiesCorrectly()
    {
        //Arr - GivenAllParameters
        var expectedId = Guid.NewGuid();
        var expectedName = "Corolla";
        var expectedChassi = 345432;


        //Act
        var car = new Car(expectedId, expectedName, expectedChassi);


        //Assert - ShouldSetThePropertiesCorrectly
        Assert.Equal(expectedId, car.Id);
        Assert.Equal(expectedName, car.Name);
        Assert.Equal(expectedChassi, car.Chassi);
    }
}