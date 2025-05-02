using MediatR;
using ApiRestFull.Interfaces;
using ApiRestFull.Models;

namespace ApiRestFull.Handlers.Livro.Queries
{
    public class ListarLivroIdQueryHandler : IRequestHandler<ListarLivroIdQuery, LivroModel>
    {
        private readonly ILivro _livroService;

        public ListarLivroIdQueryHandler(ILivro livroService)
        {
            _livroService = livroService;
        }

        public async Task<LivroModel> Handle(ListarLivroIdQuery request, CancellationToken cancellationToken)
        {
            return await _livroService.ListarLivroId(request.IdLivro);
        }
    }
}
