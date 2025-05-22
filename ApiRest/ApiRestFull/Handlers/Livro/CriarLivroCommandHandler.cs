using ApiRestFull.Commands;
using ApiRestFull.Interfaces;
using MediatR;

namespace ApiRestFull.Handlers.Livro
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