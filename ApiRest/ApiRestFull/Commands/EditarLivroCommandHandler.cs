using MediatR;
using ApiRestFull.Interfaces;
using ApiRestFull.Models;

namespace ApiRestFull.Handlers.Commands
{
    public class EditarLivroCommandHandler : IRequestHandler<EditarLivroCommand, LivroModel>
    {
        private readonly ILivro _livroService;

        public EditarLivroCommandHandler(ILivro livroService)
        {
            _livroService = livroService;
        }

        public async Task<LivroModel> Handle(EditarLivroCommand request, CancellationToken cancellationToken)
        {
            return await _livroService.EditarLivro(request.LivroEditarDto);
        }
    }
}
