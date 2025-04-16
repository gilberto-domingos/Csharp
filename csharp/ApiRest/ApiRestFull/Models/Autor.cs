using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SistemaVendas.Models;

public class Autor
{
    [Key] public int IdAutor { get; set; }

    public string Nome { get; set; }

    public string Sobrenome { get; set; }

    [JsonIgnore] public ICollection<Livro> Livros { get; set; }
}

