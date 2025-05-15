using DevLabs.Api.Interfaces;
using DevLabs.Api.Queries.Livro;
using MediatR;

namespace DevLabs.Api.Handlers.Livro
{
    public class ListarLivroIdQueryHandler : IRequestHandler<ListarLivroIdQuery, Entities.Livro>
    {
        private readonly ILivro _livroService;

        public ListarLivroIdQueryHandler(ILivro livroService)
        {
            _livroService = livroService;
        }

        public async Task<Entities.Livro> Handle(ListarLivroIdQuery request, CancellationToken cancellationToken)
        {
            return await _livroService.ListarLivroId(request.IdLivro);
        }
    }
}
