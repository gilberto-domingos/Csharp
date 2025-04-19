using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ApiRestFull.Models;

public class AutorModel
{
    [Key] public int IdAutor { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Sobrenome { get; set; } = string.Empty;
    [JsonIgnore] public ICollection<LivroModel> Livros { get; set; }

    public AutorModel() { }

    public AutorModel(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }
}

