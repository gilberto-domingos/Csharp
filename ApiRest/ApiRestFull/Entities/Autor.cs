using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ApiRestFull.Entities;

public class Autor
{
    [Key]
    public Guid IdAutor { get; init; }

    public required string Nome { get; set; } = string.Empty;

    public required string Sobrenome { get; set; } = string.Empty;

    [JsonIgnore]
    public ICollection<Livro> Livros { get; set; } = new List<Livro>();

    public Autor() { }

    public Autor(string nome, string sobrenome)
    {
        IdAutor = Guid.NewGuid();
        Nome = nome;
        Sobrenome = sobrenome;
        
        if (string.IsNullOrWhiteSpace(nome))
            throw new ArgumentException("Nome é obrigatório.", nameof(nome));

        if (string.IsNullOrWhiteSpace(sobrenome))
            throw new ArgumentException("Sobrenome é obrigatório.", nameof(sobrenome));
    }

    //Const.extra para testes automatizados, testes unitários, mocks ou imports com ID definido
    public Autor(Guid idAutor, string nome, string sobrenome)
    {
        IdAutor = idAutor;
        Nome = nome;
        Sobrenome = sobrenome;
        
        if (string.IsNullOrWhiteSpace(nome))
            throw new ArgumentException("Nome é obrigatório.", nameof(nome));

        if (string.IsNullOrWhiteSpace(sobrenome))
            throw new ArgumentException("Sobrenome é obrigatório.", nameof(sobrenome));
    }
}
