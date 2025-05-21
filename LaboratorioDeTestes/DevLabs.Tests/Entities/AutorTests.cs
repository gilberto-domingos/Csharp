    using Bogus;
    using DevLabs.Api.Entities;
    using FluentAssertions;

    namespace DevLabs.Tests.Entities;

    [Trait("Categoria", "Entidade")]
    [Trait("Entidade", "Autor")]
    [Trait("Tipo", "Unitário")]
    public class AutorTests
    {
        private readonly Faker _faker = new Faker("pt_BR");
        

        [Fact]
        public void Construtor_DeveCriarAutorComDadosValidos()
        {
            var expectedId = Guid.NewGuid();
            var expectedNome = _faker.Name.FirstName();
            var expectedSobrenome = _faker.Name.LastName();

            var autorFake = new Autor(expectedNome, expectedSobrenome, new List<Livro>());

            var livroFaker = new Faker<Livro>("pt_BR")
                .CustomInstantiator(f => new Livro(
                    f.Random.Guid(),
                    f.Lorem.Sentence(3),
                    autorFake.IdAutor,
                    autorFake
                ));

            var expectedLivros = livroFaker.Generate(2); 

            var autor = new Autor(expectedId, expectedNome, expectedSobrenome, expectedLivros);

            autor.IdAutor.Should().Be(expectedId);
            autor.Nome.Should().Be(expectedNome);
            autor.Sobrenome.Should().Be(expectedSobrenome);
            autor.Livros.Should().BeEquivalentTo(expectedLivros);
        }

        [Fact]
        public void Construtor_DeveLancarArgumentNullExceptionSeNomeForNulo()
        {
            var expectedId = Guid.NewGuid();
            string? expectedNome = null;
            var expectedSobrenome = _faker.Name.LastName();

            Action act = () => new Autor(expectedId, expectedNome!, expectedSobrenome, new List<Livro>());

            act.Should()
                .Throw<ArgumentNullException>()
                .Where(e => e.ParamName == "nome");
        }

        [Fact]
        public void Construtor_DeveLancarArgumentNullExceptionSeSobrenomeForNulo()
        {
            var expectedId = Guid.NewGuid();
            var expectedNome = _faker.Name.FirstName();
            string? expectedSobrenome = null;

            Action act = () => new Autor(expectedId, expectedNome, expectedSobrenome!, new List<Livro>());

            act.Should()
                .Throw<ArgumentNullException>()
                .Where(e => e.ParamName == "sobrenome");
        }
    }


    