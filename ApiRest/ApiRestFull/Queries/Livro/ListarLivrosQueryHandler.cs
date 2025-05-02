using MediatR;
using ApiRestFull.Interfaces;
using ApiRestFull.Models;

namespace ApiRestFull.Queries.Livro
{
    public class ListarLivrosQueryHandler : IRequestHandler<ListarLivrosQuery, List<LivroModel>>
    {
        private readonly ILivro _livroService;

        public ListarLivrosQueryHandler(ILivro livroService)
        {
            _livroService = livroService;
        }

        public async Task<List<LivroModel>> Handle(ListarLivrosQuery request, CancellationToken cancellationToken)
        {
            return await _livroService.ListarLivros();
        }
    }
}
