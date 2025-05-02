using MediatR;
using ApiRestFull.Interfaces;
using ApiRestFull.Models;
using ApiRestFull.DTOs;

namespace ApiRestFull.Handlers.Commands
{
    public class CriarLivroCommandHandler : IRequestHandler<CriarLivroCommand, LivroModel>
    {
        private readonly ILivro _livroService;

        public CriarLivroCommandHandler(ILivro livroService)
        {
            _livroService = livroService;
        }

        public async Task<LivroModel> Handle(CriarLivroCommand request, CancellationToken cancellationToken)
        {
            return await _livroService.CriarLivro(request.LivroCriarDto);
        }
    }
}
