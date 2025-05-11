using DevLabs.Api.Dtos;
using DevLabs.Api.Entities;

namespace DevLabs.Api.Interfaces;

public interface ILivro
{
    Task<List<Livro>> ListarLivros();

    Task<Livro> ListarLivroId(Guid idLivro);

    Task<List<Livro>> ListarLivrosPorIdAutor(Guid idAutor);

    Task<Livro> CriarLivro(LivroCriarDto livroCriarDto);

    Task<Livro> EditarLivro(LivroEditarDto livroEditarDto);

    Task<Livro> ExcluirLivro(Guid idLivro);
}