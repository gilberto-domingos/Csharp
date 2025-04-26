using ApiRestFull.Models;

namespace ApiRestFull.Interfaces;

public interface IAutorRepository
{
    Task<List<AutorModel>> ListarAutores();
    Task<AutorModel> ListarAutorPorId(Guid idAutor);
    Task<AutorModel> ListarAutorPorIdLivro(Guid idLivro);
    Task<AutorModel> CriarAutor(AutorModel autor);
    Task<AutorModel> EditarAutor(AutorModel autor);
    Task<AutorModel> ExcluirAutor(Guid idAutor);
}
