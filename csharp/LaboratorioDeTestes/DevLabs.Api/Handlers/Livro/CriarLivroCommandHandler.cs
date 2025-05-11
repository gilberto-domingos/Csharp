using DevLabs.Api.Interfaces;
using MediatR;
using DevLabs.Api.Entities;
using DevLabs.Api.Dtos;

namespace DevLabs.Api.Handlers.Commands
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
