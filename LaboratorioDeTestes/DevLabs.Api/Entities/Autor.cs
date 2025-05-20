using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace DevLabs.Api.Entities;

public class Autor
{
    [Key]
    public Guid IdAutor { get; init; }
    public required string Nome { get; set; } 
    public required string Sobrenome { get; set; } 

    [JsonIgnore]
    public ICollection<Livro> Livros { get; set; } = new List<Livro>();
    public Autor() { }

    [SetsRequiredMembers]
    public Autor(string nome, string sobrenome, ICollection<Livro> livros)
    {
        IdAutor = Guid.NewGuid();
        Nome = nome ?? throw new ArgumentNullException(nameof(nome));
        Sobrenome = sobrenome ?? throw new ArgumentNullException(nameof(sobrenome));
        Livros = livros ?? throw new ArgumentNullException(nameof(livros));
    }

    //Const.extra para testes automatizados, testes unitários, mocks ou imports com ID definido
    [SetsRequiredMembers]
    public Autor(Guid idAutor, string nome, string sobrenome, ICollection<Livro> livros)
    {
        IdAutor = idAutor;
        Nome = nome ?? throw new ArgumentNullException(nameof(nome));
        Sobrenome = sobrenome ?? throw new ArgumentNullException(nameof(sobrenome));
        Livros = livros ?? throw new ArgumentNullException(nameof(livros));
    }
}
