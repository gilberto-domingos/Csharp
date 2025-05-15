using Bogus;
using DevLabs.Api.Repositories;
using DevLabs.Api.Services;
using Moq;

namespace DevLabs.Tests.Services;

[Trait("Category","CarChassiValidatorServiceTests")]
public class CarChassiValidatorServiceTests
{
    private readonly Faker _faker = new Faker("pt_BR");
    
    [Fact]
    public async Task CheckIfValidAsync_GivenParams_ThenShouldReturnTrueAsync()
    {
        //Arr //Given any Params
        var validChassi = _faker.Random.Int();
        var repositoryMock = new Mock<ICarChassiValidatorRepository>();

        repositoryMock
            .Setup(r => r.CheckIfValidAsync(validChassi, It.IsAny<CancellationToken>()))
            .ReturnsAsync(true);

        var service = new CarChassiValidatorService(repositoryMock.Object);

        // Act (When)
        var result = await service.CheckIfValidAsync(validChassi, CancellationToken.None);

        // Assert (Then)
        Assert.True(result);
    }
}