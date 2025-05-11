using LaboratorioDeTestes.Dtos;
using LaboratorioDeTestes.Entities;

namespace LaboratorioDeTestes.Interfaces
{
    public interface ILivroRepository
    {
        Task<List<Livro>> ListarLivros();
        Task<Livro> ListarLivroId(Guid idLivro);
        Task<List<Livro>> ListarLivrosPorIdAutor(Guid idAutor);
        Task<Livro> CriarLivro(LivroCriarDto livroCriarDto);
        Task<Livro> EditarLivro(LivroEditarDto livroEditarDto);
        Task<Livro> ExcluirLivro(Guid idLivro);
    }
}
