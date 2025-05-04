using System.ComponentModel.DataAnnotations;

namespace LaboratorioDeTestesAPI.Entities;

public class LivroModel
{
    [Key]
    public Guid IdLivro { get; init; }

    public required string Titulo { get; set; }

    public Guid IdAutor { get; init; }

    public required AutorModel Autor { get; set; }


    public LivroModel() { }


    public LivroModel(string titulo, Guid idAutor, AutorModel autor)
    {
        IdLivro = Guid.NewGuid();
        Titulo = titulo ?? throw new ArgumentNullException(nameof(titulo), "Todos os livros devem ter título!");
        IdAutor = idAutor;
        Autor = autor ?? throw new ArgumentNullException(nameof(autor));
    }

    //Const.extra para testes automatizados, testes unitários, mocks ou imports com ID definido
    public LivroModel(Guid idLivro, string titulo, Guid idAutor, AutorModel autor)
    {
        IdLivro = idLivro;
        Titulo = titulo ?? throw new ArgumentNullException(nameof(titulo));
        IdAutor = idAutor;
        Autor = autor ?? throw new ArgumentNullException(nameof(autor));
    }

}
