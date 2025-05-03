using ApiRestFull.Interfaces;
using ApiRestFull.Entities;
using MediatR;

namespace ApiRestFull.Queries.Autor
{
    public class ListarAutorIdQueryHandler : IRequestHandler<ListarAutorIdQuery, Entities.Autor>
    {
        private readonly IAutor _autorService;

        public ListarAutorIdQueryHandler(IAutor autorService)
        {
            _autorService = autorService;
        }

        public async Task<Entities.Autor> Handle(ListarAutorIdQuery request, CancellationToken cancellationToken)
        {
            return await _autorService.ListarAutorId(request.IdAutor);
        }
    }
}
