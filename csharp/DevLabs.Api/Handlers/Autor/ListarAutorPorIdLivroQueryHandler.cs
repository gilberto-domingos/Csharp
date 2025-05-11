using LaboratorioDeTestes.Interfaces;
using LaboratorioDeTestes.Entities;
using MediatR;

namespace LaboratorioDeTestes.Queries.Autor
{
    public class ListarAutorPorIdLivroQueryHandler : IRequestHandler<ListarAutorPorIdLivroQuery, Entities.Autor>
    {
        private readonly IAutor _autorService;

        public ListarAutorPorIdLivroQueryHandler(IAutor autorService)
        {
            _autorService = autorService;
        }

        public async Task<Entities.Autor> Handle(ListarAutorPorIdLivroQuery request, CancellationToken cancellationToken)
        {
            return await _autorService.ListarAutorPorIdLivro(request.IdLivro);
        }
    }
}
