using ApiRestFull.DTOs;
using ApiRestFull.Interfaces;
using ApiRestFull.Models;
using ApiRestFull.Queries.Autor;
using MediatR;

namespace ApiRestFull.Handlers.Autor
{
    public class ListarAutorPorIdLivroQueryHandler : IRequestHandler<ListarAutorPorIdLivroQuery, RespostaApiDto<AutorModel>>
    {
        private readonly IAutor _autorService;

        public ListarAutorPorIdLivroQueryHandler(IAutor autorService)
        {
            _autorService = autorService;
        }

        public async Task<RespostaApiDto<AutorModel>> Handle(ListarAutorPorIdLivroQuery request, CancellationToken cancellationToken)
        {
            return await _autorService.ListarAutorPorIdLivro(request.IdLivro);
        }
    }
}
