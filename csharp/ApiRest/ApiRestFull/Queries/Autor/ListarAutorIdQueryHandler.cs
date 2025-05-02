using ApiRestFull.Interfaces;
using ApiRestFull.Models;
using MediatR;

namespace ApiRestFull.Queries.Autor
{
    public class ListarAutorIdQueryHandler : IRequestHandler<ListarAutorIdQuery, AutorModel>
    {
        private readonly IAutor _autorService;

        public ListarAutorIdQueryHandler(IAutor autorService)
        {
            _autorService = autorService;
        }

        public async Task<AutorModel> Handle(ListarAutorIdQuery request, CancellationToken cancellationToken)
        {
            return await _autorService.ListarAutorId(request.IdAutor);
        }
    }
}
