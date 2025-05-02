using ApiRestFull.Interfaces;
using ApiRestFull.Models;
using ApiRestFull.DTOs;
using ApiRestFull.Exceptions;

namespace ApiRestFull.Services
{
    public class AutorService : IAutor
    {
        private readonly IAutorRepository _autorRepository;

        public AutorService(IAutorRepository autorRepository)
        {
            _autorRepository = autorRepository;
        }

        public async Task<AutorModel> CriarAutor(AutorCriarDto autorCriarDto)
        {
            var autor = new AutorModel
            {
                Nome = autorCriarDto.Nome,
                Sobrenome = autorCriarDto.Sobrenome
            };

            return await _autorRepository.CriarAutor(autor);
        }

        public async Task<AutorModel> EditarAutor(AutorEditarDto autorEditarDto)
        {
            var autor = new AutorModel
            {
                IdAutor = autorEditarDto.idAutor,
                Nome = autorEditarDto.Nome,
                Sobrenome = autorEditarDto.Sobrenome
            };

            var atualizado = await _autorRepository.EditarAutor(autor);
            if (atualizado == null)
                throw new NotFoundException("Autor para edição não encontrado.");
            return atualizado;
        }

        public async Task<AutorModel> ExcluirAutor(Guid idAutor)
        {
            var resultado = await _autorRepository.ExcluirAutor(idAutor);
            if (resultado == null)
                throw new NotFoundException("Autor para exclusão não encontrado.");

            return resultado;
        }

        public async Task<List<AutorModel>> ListarAutores()
        {
            return await _autorRepository.ListarAutores();
        }

        public async Task<AutorModel> ListarAutorId(Guid idAutor)
        {
            var autor = await _autorRepository.ListarAutorPorId(idAutor);
            if (autor == null)
                throw new NotFoundException("Autor não encontrado.");
            return autor;
        }

        public async Task<AutorModel> ListarAutorPorIdLivro(Guid idLivro)
        {
            var autor = await _autorRepository.ListarAutorPorIdLivro(idLivro);
            if (autor == null)
                throw new NotFoundException("Autor não encontrado para o livro informado.");
            return autor;
        }
    }
}
