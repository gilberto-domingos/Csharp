using Bogus;
using DevLabs.Api.Commands.Autor;
using DevLabs.Api.Dtos;
using FluentAssertions;

namespace DevLabs.Tests.Commands.Autor;

[Trait("Categoria", "Command")]
[Trait("Command", "EditarAutor")]
[Trait("Tipo", "Unitário")]
public class EditarAutorCommandTests
{
    private readonly Faker _faker = new();

    private AutorEditarDto GerarDtoValido()
    {
        return new AutorEditarDto
        {
            Nome = _faker.Person.FirstName,
            Sobrenome = _faker.Person.LastName
        };
    }
    
    [Fact]
    public void Deve_Criar_Comando_Valido()
    {
        var dto = GerarDtoValido();

        var command = new EditarAutorCommand(dto);

        command.AutorEditarDto.Nome.Should().Be(dto.Nome);
        command.AutorEditarDto.Sobrenome.Should().Be(dto.Sobrenome);
    }

    [Fact]
    public void Deve_Conter_Dto_Equivalente_Ao_Passado()
    {
        var dto = GerarDtoValido();

        var command = new EditarAutorCommand(dto);
        
        command.AutorEditarDto.Should().BeEquivalentTo(dto);
    }
    
}