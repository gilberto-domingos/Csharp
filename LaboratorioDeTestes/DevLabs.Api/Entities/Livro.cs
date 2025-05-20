using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DevLabs.Api.Entities;

public class Livro
{
    [Key]
    public Guid IdLivro { get; init; }
    public required string Titulo { get; set; }
    public Guid IdAutor { get; init; }
    public required Autor Autor { get; set; }
    public Livro() { }
    
    [SetsRequiredMembers]
    public Livro(string titulo, Guid idAutor, Autor autor)
    {
        IdLivro = Guid.NewGuid();
        Titulo = titulo ?? throw new ArgumentNullException(nameof(titulo), "Todos os livros devem ter título!");
        IdAutor = idAutor;
        Autor = autor ?? throw new ArgumentNullException(nameof(autor));
    }

    //Const.extra para testes automatizados, testes unitários, mocks ou imports com ID definido
    [SetsRequiredMembers]
    public Livro(Guid idLivro, string titulo, Guid idAutor, Autor autor)
    {
        IdLivro = idLivro;
        Titulo = titulo ?? throw new ArgumentNullException(nameof(titulo));
        IdAutor = idAutor;
        Autor = autor ?? throw new ArgumentNullException(nameof(autor));
    }

}
