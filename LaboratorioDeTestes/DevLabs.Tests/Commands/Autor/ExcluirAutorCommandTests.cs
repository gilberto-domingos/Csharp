using System.Reflection;
using Bogus;
using DevLabs.Api.Commands.Autor;
using FluentAssertions;


namespace DevLabs.Tests.Commands.Autor;

[Trait("Command", "ExcluirAutorCommand")]
[Trait("Tipo", "Unit")]
public class ExcluirAutorCommandTests
{
    [Fact]
    public void Deve_Manter_Id_Informado_No_Comando_De_Exclusao()
    {
        var id = Guid.NewGuid();

        var command = new ExcluirAutorCommand(id);

        command.IdAutor.Should().Be(id);
    }
    
}