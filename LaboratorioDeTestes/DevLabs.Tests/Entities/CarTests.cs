using Bogus;
using DevLabs.Api.Entities;
using FluentAssertions;
using Xunit.Abstractions;

namespace DevLabs.Tests.Entities;
// testando com bibliotecas diferentes 
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
        var expectedId = Guid.NewGuid();
        var expectedName = _faker.Vehicle.Model();
        var expectedChassi = _faker.Random.Int();

        var car = new Car(expectedId, expectedName, expectedChassi);

        car.Id.Should().Be(expectedId);
        car.Name.Should().Be(expectedName);
        car.Chassi.Should().Be(expectedChassi);
    }

    [Fact]
    public void BogusConstructor_GivenAllParameters_ThenShouldSetThePropertiesCorrectly()
    {
        var expectedId = Guid.NewGuid();
        var expectedName = _faker.Vehicle.Model();
        var expectedChassi = _faker.Random.Int();

        _testOutputHelper.WriteLine(expectedName); 

        var car = new Car(expectedId, expectedName, expectedChassi);

        Assert.Equal(expectedId, car.Id);
        Assert.Equal(expectedName, car.Name);
        Assert.Equal(expectedChassi, car.Chassi);
    }



    [Theory]
    [InlineData("Ferrari")]
    [InlineData("Fusca ")]
    public void TheoryConstructor_GivenAllParameters_ThenShouldSetThePropertiesCorrectly(string expectedName)
    {
        var expectedId = Guid.NewGuid();

        var car = new Car(expectedId, expectedName);

        Assert.Equal(expectedId, car.Id);
        Assert.Equal(expectedName, car.Name);
    }

    [Fact]
    public void Constructor_GivenAllParameters_ThenShouldSetThePropertiesCorrectly()
    {
        var expectedId = Guid.NewGuid();
        var expectedName = "Corolla";
        var expectedChassi = 345432;

        var car = new Car(expectedId, expectedName, expectedChassi);

        Assert.Equal(expectedId, car.Id);
        Assert.Equal(expectedName, car.Name);
        Assert.Equal(expectedChassi, car.Chassi);
    }

    [Fact]
    public void Constructor_GivenEmptyConstructorParams_ThenShouldSetDefaultValues()
    {
        var car = new Car();

        Assert.Equal(Guid.Empty, car.Id);
        Assert.Equal(string.Empty, car.Name);
        Assert.Equal(0, car.Chassi);
    }
}