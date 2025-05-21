using Bogus;
using DevLabs.Api.Commands.Autor;
using DevLabs.Api.Dtos;
using FluentAssertions;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace DevLabs.Tests.Commands.Autor;

[Trait("Categoria", "Command")]
[Trait("Command", "CriarAutor")]
[Trait("Tipo", "Unitário")]
    public class CriarAutorCommandTests
    {
        private readonly Faker _faker = new();
        
        private AutorCriarDto GerarDtoValido()
        {
            return new AutorCriarDto
            {
                Nome = _faker.Person.FirstName,
                Sobrenome = _faker.Person.LastName
            };
        }
        
        [Fact]
        public void Deve_Criar_Comando_Valido()
        {
            var dto = GerarDtoValido();

            var command = new CriarAutorCommand(dto);

            command.AutorCriarDto.Nome.Should().Be(dto.Nome);
            command.AutorCriarDto.Sobrenome.Should().Be(dto.Sobrenome);
        }
        
        [Fact]
        public void Deve_Conter_Dto_Equivalente_Ao_Passado()
        {
            var dto = GerarDtoValido();

            var command = new CriarAutorCommand(dto);

            command.AutorCriarDto.Should().BeEquivalentTo(dto);
        }
        
    }
