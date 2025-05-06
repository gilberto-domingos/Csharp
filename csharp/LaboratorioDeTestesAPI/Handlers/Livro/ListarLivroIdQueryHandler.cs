using MediatR;
using LaboratorioDeTestesAPI.Interfaces;
using LaboratorioDeTestesAPI.Entities;

namespace LaboratorioDeTestesAPI.Handlers.Livro.Queries
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
