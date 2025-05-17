using Bogus;
using DevLabs.Api.Handlers.Car;
using DevLabs.Api.Interfaces;
using DevLabs.Api.Queries.Car;
using Moq;

namespace DevLabs.Tests.Handlers;

[Trait("Category","CarChassiValidatorHandlers")]
public class ChassiValidatorQueryHandlerTests
{
    private readonly Mock<ICarChassiValidator> _mockValidator;
    private readonly ChassiValidatorQueryHandler _queryHandler;
    private readonly Faker _faker = new Faker("pt_BR");
    
    public ChassiValidatorQueryHandlerTests()
    {
        _mockValidator = new Mock<ICarChassiValidator>();
        _queryHandler = new ChassiValidatorQueryHandler(_mockValidator.Object);
    }

    [Fact]
    public async Task Handle_ShouldReturnTrue_WhenChassiIsValid()
    {
        //Arr
        var chassi = _faker.Random.Int();
        var query = new ChassiValidadorQuery(chassi);

        _mockValidator
            .Setup(icar => icar.CheckIfValidAsync(chassi, It.IsAny<CancellationToken>()))
            .ReturnsAsync(true);
        
        //Act
        var result = await _queryHandler.Handle(query, CancellationToken.None);
        
        //Assert
        Assert.True(result);
    }



}