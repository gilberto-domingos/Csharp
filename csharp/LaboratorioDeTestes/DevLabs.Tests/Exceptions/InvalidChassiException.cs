using Bogus;
using DevLabs.Api.Exceptions;
using FluentAssertions;
using Xunit.Abstractions;


namespace DevLabs.Tests.Exceptions;

public sealed class InvalidChassiExceptionTests
{
    private readonly Faker _faker = new Faker("pt_BR");
    private readonly ITestOutputHelper _testOutputHelper;

    public InvalidChassiExceptionTests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void Constructor_GivenMessage_ThenShouldSetMessageToException()
    {
        //Arr
        var message = _faker.Lorem.Text();
        _testOutputHelper.WriteLine(message);

        //Act
        var exception = new InvalidChassiException(message);

        //Assert
        exception.Message.Should().Be(message);
    }
    
}