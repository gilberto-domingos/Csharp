using System.ComponentModel.DataAnnotations;

namespace SistemaVendas.Models;

public class Livro
{
   [Key] public int IdLivro { get; set; }
    public string Titulo { get; set; }
    public Autor Autor { get; set; }
}