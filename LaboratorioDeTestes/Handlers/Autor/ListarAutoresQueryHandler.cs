using LaboratorioDeTestes.Interfaces;
using MediatR;

namespace LaboratorioDeTestes.Queries.Autor
{
    public class ListarAutoresQueryHandler : IRequestHandler<ListarAutoresQuery, List<Entities.Autor>>
    {
        private readonly IAutor _autorService;

        public ListarAutoresQueryHandler(IAutor autorService)
        {
            _autorService = autorService;
        }

        public async Task<List<Entities.Autor>> Handle(ListarAutoresQuery request, CancellationToken cancellationToken)
        {
            return await _autorService.ListarAutores();
        }
    }
}
