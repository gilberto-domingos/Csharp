using ApiRestFull.DTOs;
using ApiRestFull.Models;

namespace ApiRestFull.Interfaces;

public interface ILivro
{
    Task<RespostaApiDto<List<LivroModel>>> ListarLivros();

    Task<RespostaApiDto<LivroModel>> ListarLivroId(Guid idLivro);

    Task<RespostaApiDto<List<LivroModel>>> ListarLivroPorIdAutor(Guid idAutor);

    Task<RespostaApiDto<List<LivroModel>>> CriarLivro(LivroCriarDto livroModelCriarDto);

    Task<RespostaApiDto<List<LivroModel>>> EditarLivro(LivroEditarDto livroEditarDto);

    Task<RespostaApiDto<List<LivroModel>>> ExcluirLivro(Guid idLivro);
}