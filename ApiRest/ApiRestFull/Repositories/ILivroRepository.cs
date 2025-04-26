using ApiRestFull.Models;
using ApiRestFull.DTOs;

namespace ApiRestFull.Interfaces
{
    public interface ILivroRepository
    {
        Task<List<LivroModel>> ListarLivros();
        Task<LivroModel?> ListarLivroId(Guid idLivro);
        Task<List<LivroModel>> ListarLivroPorIdAutor(Guid idAutor);
        Task<List<LivroModel>> CriarLivro(LivroCriarDto livroCriarDto);
        Task<List<LivroModel>> EditarLivro(LivroEditarDto livroEditarDto);
        Task<List<LivroModel>> ExcluirLivro(Guid idLivro);
    }
}
