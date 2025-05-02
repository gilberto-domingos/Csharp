using ApiRestFull.DTOs;
using ApiRestFull.Models;

namespace ApiRestFull.Interfaces;

public interface ILivro
{
    Task<List<LivroModel>> ListarLivros();

    Task<LivroModel> ListarLivroId(Guid idLivro);

    Task<List<LivroModel>> ListarLivrosPorIdAutor(Guid idAutor);

    Task<LivroModel> CriarLivro(LivroCriarDto livroCriarDto);

    Task<LivroModel> EditarLivro(LivroEditarDto livroEditarDto);

    Task<LivroModel> ExcluirLivro(Guid idLivro);
}