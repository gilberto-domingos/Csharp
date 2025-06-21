using System.ComponentModel.DataAnnotations;

namespace ApiRestFull.Entities;

public class Livro
{
    [Key]
    public Guid IdLivro { get; init; }

    public required string Titulo { get; set; } = string.Empty;

    public Guid IdAutor { get; init; }

    public required Autor Autor { get; set; }

    public Livro() 
    {
        IdLivro = Guid.NewGuid();
    }

    public Livro(string titulo, Guid idAutor, Autor autor)
    {
        if (string.IsNullOrWhiteSpace(titulo))
            throw new ArgumentException("Título é obrigatório.", nameof(titulo));

        if (autor is null)
            throw new ArgumentNullException(nameof(autor), "Autor é obrigatório.");

        IdLivro = Guid.NewGuid();
        Titulo = titulo;
        IdAutor = idAutor;
        Autor = autor;
    }

    // Construtor para testes ou importação com id definido
    public Livro(Guid idLivro, string titulo, Guid idAutor, Autor autor)
    {
        if (idLivro == Guid.Empty)
            throw new ArgumentException("IdLivro não pode ser vazio.", nameof(idLivro));

        if (string.IsNullOrWhiteSpace(titulo))
            throw new ArgumentException("Título é obrigatório.", nameof(titulo));

        if (autor is null)
            throw new ArgumentNullException(nameof(autor), "Autor é obrigatório.");

        IdLivro = idLivro;
        Titulo = titulo;
        IdAutor = idAutor;
        Autor = autor;
    }
}