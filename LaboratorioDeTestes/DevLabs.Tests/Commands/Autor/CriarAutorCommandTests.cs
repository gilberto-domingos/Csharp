using Bogus;
using DevLabs.Api.Commands.Autor;
using DevLabs.Api.Dtos;
using FluentAssertions;

namespace DevLabs.Tests.Commands.Autor;

[Trait("Categoria", "Command")]
[Trait("Command", "CriarAutor")]
[Trait("Tipo", "Unitário")]
    public class CriarAutorCommandTests
    {
        private readonly Faker _faker = new();
        // campos são required precisa inicializar via object initializer
        private LivroCriarDto GerarLivroDtoValido()
        {
            var autorId = Guid.NewGuid();
    
            return new LivroCriarDto
            {
                Titulo = _faker.Lorem.Sentence(),
                IdAutor = autorId,
                Autor = new AutorVinculoDto
                {
                    IdAutor = autorId,
                    Nome = _faker.Person.FirstName,
                    Sobrenome = _faker.Person.LastName
                }
            };
        }
        
        private AutorCriarDto GerarAutorDtoValido()
        {
            return new AutorCriarDto
            {
                Nome = _faker.Person.FirstName,
                Sobrenome = _faker.Person.LastName,
                Livros = new List<LivroCriarDto>
                {
                    GerarLivroDtoValido()
                }
            };
        }
        
        [Fact]
        public void Deve_Criar_Comando_Valido()
        {
            var dto = GerarAutorDtoValido();

            var command = new CriarAutorCommand(dto);

            command.AutorCriarDto.Nome.Should().Be(dto.Nome);
            command.AutorCriarDto.Sobrenome.Should().Be(dto.Sobrenome);
        }
        
        [Fact]
        public void Deve_Conter_Dto_Equivalente_Ao_Passado()
        {
            var dto = GerarAutorDtoValido();

            var command = new CriarAutorCommand(dto);

            command.AutorCriarDto.Should().BeEquivalentTo(dto);
        }
        
    }
