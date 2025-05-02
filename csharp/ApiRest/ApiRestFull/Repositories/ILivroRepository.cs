using ApiRestFull.Models;
using ApiRestFull.DTOs;

namespace ApiRestFull.Interfaces
{
    public interface ILivroRepository
    {
        Task<List<LivroModel>> ListarLivros();
        Task<LivroModel> ListarLivroId(Guid idLivro);
        Task<List<LivroModel>> ListarLivrosPorIdAutor(Guid idAutor);
        Task<LivroModel> CriarLivro(LivroCriarDto livroCriarDto);
        Task<LivroModel> EditarLivro(LivroEditarDto livroEditarDto);
        Task<LivroModel> ExcluirLivro(Guid idLivro);
    }
}
