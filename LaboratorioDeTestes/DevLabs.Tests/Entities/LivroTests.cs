using Bogus;
using DevLabs.Api.Entities;
using FluentAssertions;

namespace DevLabs.Tests.Entities;


[Trait("Categoria", "Entidade")]
[Trait("Entidade", "Livro")]
[Trait("Tipo", "Unitário")]
public class LivroTests
{
    private readonly Faker _faker = new();

    [Fact]
    public void Construtor_DeveCriarLivroComDadosValidos()
    {
        var expectedIdLivro = Guid.NewGuid();
        var expectedTitulo = _faker.Lorem.Sentence();
        var expectedIdAutor = Guid.NewGuid();
        var expectedAutor = new Autor(
            expectedIdAutor,
            _faker.Name.FirstName(),
            _faker.Name.LastName(),
            new List<Livro>()
        );

        var livro = new Livro(expectedIdLivro, expectedTitulo, expectedIdAutor, expectedAutor);

        livro.IdLivro.Should().Be(expectedIdLivro);
        livro.Titulo.Should().Be(expectedTitulo);
        livro.IdAutor.Should().Be(expectedIdAutor);
        livro.Autor.Should().Be(expectedAutor);
    }

    [Fact]
    public void Construtor_DeveLancarExcecaoSeTituloForNulo()
    {
        var expectedIdLivro = Guid.NewGuid();
        string? expectedTitulo = null;
        var expectedIdAutor = Guid.NewGuid();
        var expectedAutor = new Autor(
            expectedIdAutor,
            _faker.Name.FirstName(),
            _faker.Name.LastName(),
            new List<Livro>()
        );

        Action act = () => new Livro(expectedIdLivro, expectedTitulo!, expectedIdAutor, expectedAutor);

        act.Should()
            .Throw<ArgumentNullException>()
            .WithParameterName("titulo");
    }

    [Fact]
    public void Construtor_DeveLancarExcecaoSeAutorForNulo()
    {
        var expectedIdLivro = Guid.NewGuid();
        var expectedTitulo = _faker.Lorem.Sentence();
        var expectedIdAutor = Guid.NewGuid();
        Autor? expectedAutor = null;
        
        Action act = () => new Livro(expectedIdLivro, expectedTitulo, expectedIdAutor, expectedAutor!);

        act.Should()
            .Throw<ArgumentNullException>()
            .WithParameterName("autor");
    }
}


