using Bogus;
using DevLabs.Api.Exceptions;
using FluentAssertions;
using Xunit.Abstractions;


namespace DevLabs.Tests.Exceptions;

[Trait("Category","CarException")]
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
        var message = _faker.Lorem.Text();
        _testOutputHelper.WriteLine(message);

        var exception = new InvalidChassiException(message);

        exception.Message.Should().Be(message);
    }
    
}