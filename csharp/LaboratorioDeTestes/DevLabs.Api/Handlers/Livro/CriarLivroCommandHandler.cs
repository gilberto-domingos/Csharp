using DevLabs.Api.Interfaces;
using DevLabs.Api.Commands.Livro;
using MediatR;

namespace DevLabs.Api.Handlers.Livro
{
    public class CriarLivroCommandHandler : IRequestHandler<CriarLivroCommand, Entities.Livro>
    {
        private readonly ILivro _livroService;

        public CriarLivroCommandHandler(ILivro livroService)
        {
            _livroService = livroService;
        }

        public async Task<Entities.Livro> Handle(CriarLivroCommand request, CancellationToken cancellationToken)
        {
            return await _livroService.CriarLivro(request.LivroCriarDto);
        }
    }
}
