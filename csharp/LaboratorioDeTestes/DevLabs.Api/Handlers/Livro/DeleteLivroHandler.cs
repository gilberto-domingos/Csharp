using DevLabs.Api.Interfaces;
using MediatR;
using DevLabs.Api.Entities;

namespace DevLabs.Api.Handlers.Livro.Commands
{
    public class DeleteLivroHandler : IRequestHandler<DeleteLivroCommand, Entities.Livro>
    {
        private readonly ILivro _livroService;

        public DeleteLivroHandler(ILivro livroService)
        {
            _livroService = livroService;
        }

        public async Task<Entities.Livro> Handle(DeleteLivroCommand request, CancellationToken cancellationToken)
        {
            return await _livroService.ExcluirLivro(request.IdLivro);
        }
    }
}
