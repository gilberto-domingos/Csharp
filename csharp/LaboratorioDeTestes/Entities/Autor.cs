using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LaboratorioDeTestes.Entities;

public class Autor
{
    [Key]
    public Guid IdAutor { get; init; }

    public required string Nome { get; set; }

    public required string Sobrenome { get; set; }

    [JsonIgnore]
    public ICollection<Livro> Livros { get; set; } = new List<Livro>();

    public Autor() { }

    public Autor(string nome, string sobrenome)
    {
        IdAutor = Guid.NewGuid();
        Nome = nome ?? throw new ArgumentNullException(nameof(nome));
        Sobrenome = sobrenome ?? throw new ArgumentNullException(nameof(sobrenome));
    }

    //Const.extra para testes automatizados, testes unitários, mocks ou imports com ID definido
    public Autor(Guid idAutor, string nome, string sobrenome)
    {
        IdAutor = idAutor;
        Nome = nome ?? throw new ArgumentNullException(nameof(nome));
        Sobrenome = sobrenome ?? throw new ArgumentNullException(nameof(sobrenome));
    }
}
