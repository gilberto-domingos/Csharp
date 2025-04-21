using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ApiRestFull.Models;

public class AutorModel
{
    [Key]
    public int IdAutor { get; set; }

    [Required]
    public required string Nome { get; set; } = string.Empty;

    [Required]
    public required string Sobrenome { get; set; } = string.Empty;

    [JsonIgnore]
    public ICollection<LivroModel> Livros { get; set; }

    public AutorModel() { }

    public AutorModel(string nome, string sobrenome)
    {
        Nome = nome ?? throw new ArgumentNullException(nameof(nome));
        Sobrenome = sobrenome ?? throw new ArgumentNullException(nameof(sobrenome));
    }
}
