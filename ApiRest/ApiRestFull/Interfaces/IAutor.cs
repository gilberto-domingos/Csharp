using ApiRestFull.DTOs;
using ApiRestFull.Models;

namespace ApiRestFull.Interfaces;

public interface IAutor
{

    Task<RespostaApiDto<List<AutorModel>>> ListarAutores();
    Task<RespostaApiDto<AutorModel>> ListarAutorId(int idAutor);
    Task<RespostaApiDto<AutorModel>> ListarAutorPorIdLivro(int IdLivro);
    Task<RespostaApiDto<List<AutorModel>>> CriarAutor(AutorModelCriarDto autorModelCriarDto);
    Task<RespostaApiDto<List<AutorModel>>> EditarAutor(AutorEditarDto autorEditarDto);
    Task<RespostaApiDto<List<AutorModel>>> ExcluirAutor(int IAuAutor);






}