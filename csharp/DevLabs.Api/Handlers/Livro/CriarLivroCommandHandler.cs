using LaboratorioDeTestes.Interfaces;
using MediatR;
using LaboratorioDeTestes.Entities;
using LaboratorioDeTestes.Dtos;

namespace LaboratorioDeTestes.Handlers.Commands
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
