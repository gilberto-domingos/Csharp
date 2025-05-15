using DevLabs.Api.Interfaces;
using DevLabs.Api.Queries.Livro;
using MediatR;

namespace DevLabs.Api.Handlers.Livro
{
    public class ListarLivrosQueryHandler : IRequestHandler<ListarLivrosQuery, List<Entities.Livro>>
    {
        private readonly ILivro _livroService;

        public ListarLivrosQueryHandler(ILivro livroService)
        {
            _livroService = livroService;
        }

        public async Task<List<Entities.Livro>> Handle(ListarLivrosQuery request, CancellationToken cancellationToken)
        {
            return await _livroService.ListarLivros();
        }
    }
}
