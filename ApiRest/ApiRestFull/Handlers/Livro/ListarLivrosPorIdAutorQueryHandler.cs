using MediatR;
using ApiRestFull.Interfaces;
using ApiRestFull.Entities;

namespace ApiRestFull.Handlers.Livro.Queries
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
