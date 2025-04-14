using System.Text.Json.Serialization;

namespace SistemaVendas.Entities;

public class Autor
{
    public int Id { get; set; }

    public string Nome { get; set; }

    public string Sobrenome { get; set; }

    [JsonIgnore] public ICollection<Livro> Livros { get; set; }
}