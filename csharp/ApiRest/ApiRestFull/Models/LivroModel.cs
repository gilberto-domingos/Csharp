using System.ComponentModel.DataAnnotations;

namespace ApiRestFull.Models;

public class LivroModel
{
    [Key]
    public int IdLivro { get; set; }

    [Required]
    public string Titulo { get; set; }

    [Required]
    public int IdAutor { get; set; }

    [Required]
    public AutorModel Autor { get; set; }

    public LivroModel() { }

    public LivroModel(string titulo, int idAutor, AutorModel autor)
    {
        Titulo = titulo ?? throw new ArgumentNullException(nameof(titulo), "Todos os livros devem ter titulo !");
        IdAutor = idAutor;
        Autor = autor ?? throw new ArgumentNullException(nameof(autor));
    }
}
