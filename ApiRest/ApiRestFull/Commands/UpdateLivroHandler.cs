using MediatR;
using ApiRestFull.Interfaces;
using ApiRestFull.Models;

namespace ApiRestFull.Handlers.Livro.Commands
{
    public class UpdateLivroHandler : IRequestHandler<UpdateLivroCommand, LivroModel>
    {
        private readonly ILivro _livroService;

        public UpdateLivroHandler(ILivro livroService)
        {
            _livroService = livroService;
        }

        public async Task<LivroModel> Handle(UpdateLivroCommand request, CancellationToken cancellationToken)
        {
            return await _livroService.EditarLivro(request.LivroEditarDto);
        }
    }
}
