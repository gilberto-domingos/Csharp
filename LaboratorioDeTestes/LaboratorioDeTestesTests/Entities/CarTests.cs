using LaboratorioDeTestes.Entities;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Xunit;

namespace LaboratorioDeTestes.Tests.Entities;

public sealed class CarTests
{
    [Theory]
    [InlineData("Ferrari")]
    [InlineData("Fusca")]
    public void Constructor_GivenAllParameters_ThenShouldSetThePropertiesCorrectly2(string expectedName)
    {
        //Arr - GivenAllParameters
        var expectedId = Guid.NewGuid();

        //Act
        var car = new Car(expectedId, expectedName);

        //Assert - ShouldSetThePropertiesCorrectly
        Assert.Equal(expectedId, car.Id);
        Assert.Equal(expectedName, car.Name);
    }

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

    [Fact]
    public void Constructor_GivenEmptyConstructorParams_ThenShouldSetDefaultValues()
    {
        // Act
        var car = new Car();

        // Assert 
        Assert.Equal(Guid.Empty, car.Id);
        Assert.Equal("", car.Name);
    }
}