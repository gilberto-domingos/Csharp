using LaboratorioDeTestes.Dtos;
using LaboratorioDeTestes.Entities;

namespace LaboratorioDeTestes.Interfaces;

public interface IAutor
{

    Task<List<Autor>> ListarAutores();
    Task<Autor> ListarAutorId(Guid idAutor);
    Task<Autor> ListarAutorPorIdLivro(Guid idLivro);
    Task<Autor> CriarAutor(AutorCriarDto autorCriarDto);
    Task<Autor> EditarAutor(AutorEditarDto autorEditarDto);
    Task<Autor> ExcluirAutor(Guid idAutor);

}