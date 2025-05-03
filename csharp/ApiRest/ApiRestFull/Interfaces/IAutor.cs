using ApiRestFull.DTOs;
using ApiRestFull.Entities;

namespace ApiRestFull.Interfaces;

public interface IAutor
{

    Task<List<Autor>> ListarAutores();
    Task<Autor> ListarAutorId(Guid idAutor);
    Task<Autor> ListarAutorPorIdLivro(Guid idLivro);
    Task<Autor> CriarAutor(AutorCriarDto autorCriarDto);
    Task<Autor> EditarAutor(AutorEditarDto autorEditarDto);
    Task<Autor> ExcluirAutor(Guid idAutor);

}