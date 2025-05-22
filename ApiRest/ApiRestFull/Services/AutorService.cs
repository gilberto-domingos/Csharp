using ApiRestFull.Interfaces;
using ApiRestFull.Entities;
using ApiRestFull.Dtos;
using ApiRestFull.Exceptions;
using Mapster;

namespace ApiRestFull.Services
{
    public class AutorService : IAutor
    {
        private readonly IAutorRepository _autorRepository;

        public AutorService(IAutorRepository autorRepository)
        {
            _autorRepository = autorRepository;
        }

        public async Task<Autor> CriarAutor(AutorCriarDto autorCriarDto)
        {
            var autor = autorCriarDto.Adapt<Autor>();

            return await _autorRepository.CriarAutor(autor);
        }

        public async Task<Autor> EditarAutor(AutorEditarDto autorEditarDto)
        {
            var autor = autorEditarDto.Adapt<Autor>();

            var atualizado = await _autorRepository.EditarAutor(autor);
            if (atualizado == null)
                throw new NotFoundException("Autor para edição não encontrado.");
            return atualizado;
        }

        public async Task<Autor> ExcluirAutor(Guid idAutor)
        {
            var resultado = await _autorRepository.ExcluirAutor(idAutor);
            if (resultado == null)
                throw new NotFoundException("Autor para exclusão não encontrado.");

            return resultado;
        }

        public async Task<List<Autor>> ListarAutores()
        {
            return await _autorRepository.ListarAutores();
        }

        public async Task<Autor> ListarAutorId(Guid idAutor)
        {
            var autor = await _autorRepository.ListarAutorPorId(idAutor);
            if (autor == null)
                throw new NotFoundException("Autor não encontrado.");
            return autor;
        }

        public async Task<Autor> ListarAutorPorIdLivro(Guid idLivro)
        {
            var autor = await _autorRepository.ListarAutorPorIdLivro(idLivro);
            if (autor == null)
                throw new NotFoundException("Autor não encontrado para o livro informado.");
            return autor;
        }
    }
}
