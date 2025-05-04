using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LaboratorioDeTestesAPI.Entities;

public class AutorModel
{
    [Key]
    public Guid IdAutor { get; init; }

    public required string Nome { get; set; }

    public required string Sobrenome { get; set; }

    [JsonIgnore]
    public ICollection<LivroModel> Livros { get; set; } = new List<LivroModel>();

    public AutorModel() { }

    public AutorModel(string nome, string sobrenome)
    {
        IdAutor = Guid.NewGuid();
        Nome = nome ?? throw new ArgumentNullException(nameof(nome));
        Sobrenome = sobrenome ?? throw new ArgumentNullException(nameof(sobrenome));
    }

    //Const.extra para testes automatizados, testes unitários, mocks ou imports com ID definido
    public AutorModel(Guid idAutor, string nome, string sobrenome)
    {
        IdAutor = idAutor;
        Nome = nome ?? throw new ArgumentNullException(nameof(nome));
        Sobrenome = sobrenome ?? throw new ArgumentNullException(nameof(sobrenome));
    }
}
