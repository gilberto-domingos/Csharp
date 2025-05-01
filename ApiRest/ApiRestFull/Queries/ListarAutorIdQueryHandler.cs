using ApiRestFull.DTOs;
using ApiRestFull.Interfaces;
using ApiRestFull.Models;
using ApiRestFull.Queries.Autor;
using MediatR;

namespace ApiRestFull.Handlers.Autor
{
    public class ListarAutorIdQueryHandler : IRequestHandler<ListarAutorIdQuery, RespostaApiDto<AutorModel>>
    {
        private readonly IAutor _autorService;

        public ListarAutorIdQueryHandler(IAutor autorService)
        {
            _autorService = autorService;
        }

        public async Task<RespostaApiDto<AutorModel>> Handle(ListarAutorIdQuery request, CancellationToken cancellationToken)
        {
            return await _autorService.ListarAutorId(request.IdAutor);
        }
    }
}
