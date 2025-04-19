using System.ComponentModel.DataAnnotations;

namespace ApiRestFull.Models;

public class LivroModel
{
    [Key] public int IdLivro { get; set; }
    public string Titulo { get; set; }
    public int IdAutor { get; set; }
    public AutorModel AutorModel { get; set; }
}