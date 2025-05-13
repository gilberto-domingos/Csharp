using Bogus;


using DevLabs.Api.Entities;
using FluentAssertions;
using Xunit.Abstractions;

namespace DevLabs.Tests.Entities;

[Trait("Category","CarEntity")]
public sealed class CarTests
{
    private readonly Faker _faker = new Faker("pt_BR");
    private readonly ITestOutputHelper _testOutputHelper;

    public CarTests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void FluentAssertionsConstructor_GivenAllParameters_ThenShouldSetThePropertiesCorrectly()
    {
        // Fluent Assertions
        //Arr - GivenAllParameters
        var expectedId = Guid.NewGuid();
        var expectedName = _faker.Vehicle.Model();
        var expectedChassi = _faker.Random.Int();

        //Act
        var car = new Car(expectedId, expectedName, expectedChassi);

        //Assert - ThenShouldSetThePropertiesCorrectly
        car.Id.Should().Be(expectedId);
        car.Name.Should().Be(expectedName);
        car.Chassi.Should().Be(expectedChassi);
    }

    [Fact]
    public void BogusConstructor_GivenAllParameters_ThenShouldSetThePropertiesCorrectly()
    {
        // BOGUS
        //Arr - GivenAllParameters
        var expectedId = Guid.NewGuid();
        var expectedName = _faker.Vehicle.Model();
        var expectedChassi = _faker.Random.Int();

        _testOutputHelper.WriteLine(expectedName); // se precisar immprimir na console
        // dotnet test --logger:"console;verbosity=detailed"

        //Act
        var car = new Car(expectedId, expectedName, expectedChassi);

        //Assert - ShouldSetThePropertiesCorrectly
        Assert.Equal(expectedId, car.Id);
        Assert.Equal(expectedName, car.Name);
        Assert.Equal(expectedChassi, car.Chassi);
    }



    [Theory]
    [InlineData("Ferrari")]
    [InlineData("Fusca ")]

    public void TheoryConstructor_GivenAllParameters_ThenShouldSetThePropertiesCorrectly(string expectedName)
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
        Assert.Equal(string.Empty, car.Name);
        Assert.Equal(0, car.Chassi);
    }
}