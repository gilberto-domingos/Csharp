using LaboratorioDeTestesAPI.Exceptions;
using LaboratorioDeTestesAPI.Interfaces;
using LaboratorioDeTestesAPI.Dtos;
using LaboratorioDeTestesAPI.Entities;

namespace LaboratorioDeTestesAPI.Services
{
    public class LivroService : ILivro
    {
        private readonly ILivroRepository _livroRepository;

        public LivroService(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public async Task<List<Livro>> ListarLivros()
        {
            return await _livroRepository.ListarLivros();
        }

        public async Task<Livro> ListarLivroId(Guid idLivro)
        {
            var livro = await _livroRepository.ListarLivroId(idLivro);
            if (livro == null)
                throw new NotFoundException($"Livro com ID {idLivro} não encontrado.");

            return livro;
        }

        public async Task<List<Livro>> ListarLivrosPorIdAutor(Guid idAutor)
        {
            var livros = await _livroRepository.ListarLivrosPorIdAutor(idAutor);
            if (livros == null || !livros.Any())
                throw new NotFoundException($"Nenhum livro encontrado para o autor com ID {idAutor}.");

            return livros;
        }

        public async Task<Livro> CriarLivro(LivroCriarDto livroCriarDto)
        {
            return await _livroRepository.CriarLivro(livroCriarDto);
        }

        public async Task<Livro> EditarLivro(LivroEditarDto livroEditarDto)
        {
            var livroEditado = await _livroRepository.EditarLivro(livroEditarDto);
            if (livroEditado == null)
                throw new NotFoundException($"Livro com ID {livroEditarDto.IdLivro} não encontrado para edição.");

            return livroEditado;
        }

        public async Task<Livro> ExcluirLivro(Guid idLivro)
        {
            var livroExcluido = await _livroRepository.ExcluirLivro(idLivro);
            if (livroExcluido == null)
                throw new NotFoundException($"Livro com ID {idLivro} não encontrado para exclusão.");

            return livroExcluido;
        }
    }
}
