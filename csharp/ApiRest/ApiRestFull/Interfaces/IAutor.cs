using ApiRestFull.DTOs;
using ApiRestFull.Models;

namespace ApiRestFull.Interfaces;

public interface IAutor
{

    Task<List<AutorModel>> ListarAutores();
    Task<AutorModel> ListarAutorId(Guid idAutor);
    Task<AutorModel> ListarAutorPorIdLivro(Guid idLivro);
    Task<AutorModel> CriarAutor(AutorCriarDto autorCriarDto);
    Task<AutorModel> EditarAutor(AutorEditarDto autorEditarDto);
    Task<AutorModel> ExcluirAutor(Guid idAutor);

}