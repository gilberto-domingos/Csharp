using MediatR;
using LaboratorioDeTestesAPI.Interfaces;
using LaboratorioDeTestesAPI.Entities;
using LaboratorioDeTestesAPI.Dtos;

namespace LaboratorioDeTestesAPI.Handlers.Commands
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
