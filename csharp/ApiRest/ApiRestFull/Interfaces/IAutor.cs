using ApiRestFull.DTOs;
using ApiRestFull.Models;

namespace ApiRestFull.Interfaces;

public interface IAutor
{

    Task<RespostaApiDto<List<AutorModel>>> ListarAutores();
    Task<RespostaApiDto<AutorModel>> ListarAutorId(Guid idAutor);
    Task<RespostaApiDto<AutorModel>> ListarAutorPorIdLivro(Guid idLivro);
    Task<RespostaApiDto<List<AutorModel>>> CriarAutor(AutorCriarDto autorCriarDto);
    Task<RespostaApiDto<List<AutorModel>>> EditarAutor(AutorEditarDto autorEditarDto);
    Task<RespostaApiDto<List<AutorModel>>> ExcluirAutor(Guid idAutor);






}