using ApiRestFull.Interfaces;
using ApiRestFull.Models;
using MediatR;

namespace ApiRestFull.Queries.Autor
{
    public class ListarAutoresQueryHandler : IRequestHandler<ListarAutoresQuery, List<AutorModel>>
    {
        private readonly IAutor _autorService;

        public ListarAutoresQueryHandler(IAutor autorService)
        {
            _autorService = autorService;
        }

        public async Task<List<AutorModel>> Handle(ListarAutoresQuery request, CancellationToken cancellationToken)
        {
            return await _autorService.ListarAutores();
        }
    }
}
