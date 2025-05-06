using LaboratorioDeTestesAPI.Entities;

namespace LaboratorioDeTestesAPI.Interfaces;

public interface IAutorRepository
{
    Task<List<Autor>> ListarAutores();
    Task<Autor> ListarAutorPorId(Guid idAutor);
    Task<Autor> ListarAutorPorIdLivro(Guid idLivro);
    Task<Autor> CriarAutor(Autor autor);
    Task<Autor> EditarAutor(Autor autor);
    Task<Autor> ExcluirAutor(Guid idAutor);
}
