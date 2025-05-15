using DevLabs.Api.Interfaces;
using DevLabs.Api.Queries.Livro;
using MediatR;

namespace DevLabs.Api.Handlers.Livro
{
    public class ListarLivrosPorIdAutorQueryHandler : IRequestHandler<ListarLivrosPorIdAutorQuery, List<Entities.Livro>>
    {
        private readonly ILivro _livroService;

        public ListarLivrosPorIdAutorQueryHandler(ILivro livroService)
        {
            _livroService = livroService;
        }

        public async Task<List<Entities.Livro>> Handle(ListarLivrosPorIdAutorQuery request, CancellationToken cancellationToken)
        {
            return await _livroService.ListarLivrosPorIdAutor(request.IdAutor);
        }
    }
}
