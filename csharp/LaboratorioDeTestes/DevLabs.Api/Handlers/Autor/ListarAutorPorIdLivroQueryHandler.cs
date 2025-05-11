using DevLabs.Api.Interfaces;
using DevLabs.Api.Entities;
using MediatR;

namespace DevLabs.Api.Queries.Autor
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
