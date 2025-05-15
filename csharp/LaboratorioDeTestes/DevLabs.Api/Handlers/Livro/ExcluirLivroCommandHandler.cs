using MediatR;
using DevLabs.Api.Interfaces;
using DevLabs.Api.Commands.Livro;

namespace DevLabs.Api.Handlers.Livro
{
    public class ExcluirLivroCommandHandler : IRequestHandler<ExcluirLivroCommand, Entities.Livro>
    {
        private readonly ILivro _livroService;

        public ExcluirLivroCommandHandler(ILivro livroService)
        {
            _livroService = livroService;
        }

        public async Task<Entities.Livro> Handle(ExcluirLivroCommand request, CancellationToken cancellationToken)
        {
            return await _livroService.ExcluirLivro(request.IdLivro);
        }
    }
}
