using Bogus;
using DevLabs.Api.Exceptions;
using FluentAssertions;
using Xunit.Abstractions;


namespace DevLabs.Tests.Exceptions;

[Trait("Category", "Exception")]
[Trait("Type", "UnitTest")]
public sealed class InvalidChassiExceptionTests
{
    private readonly Faker _faker = new Faker("pt_BR");

    [Fact]
    public void Constructor_GivenMessage_ThenShouldSetMessageToException()
    {
        var message = _faker.Lorem.Text();

        var exception = new InvalidChassiException(message);

        exception.Message.Should().Be(message);
    }
    
}