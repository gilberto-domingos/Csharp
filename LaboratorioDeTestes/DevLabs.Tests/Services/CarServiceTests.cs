using DevLabs.Api.Services;
using Moq;

namespace DevLabs.Tests.Services;

[Trait("Category","CarChassiValidatorServiceTests")]
public class CarServiceTests
{
    [Fact]
    public async Task CheckIfValidAsync_GivenParams_ThenShouldReturnTrueAsync()
    {
        //Arr //Given any Params
        var anyId = Guid.NewGuid();
        var repositoryMock = new Mock<ICarRepository>();
        repositoryMock
            .Setup(r => r.CheckChassiExistsAsync(anyId, It.IsAny<CancellationToken>()))
            .ReturnsAsync(true);

        var service = new CarChassiValidatorService(repositoryMock.Object);
            
        //Act //When
        var result = await service.CheckIfValidAsync(anyId, CancellationToken.None);

        //Assert //Then ShouldReturn
        Assert.True(result);
    }
}