using MediatR;
using ApiRestFull.Interfaces;
using ApiRestFull.Models;

namespace ApiRestFull.Handlers.Livro.Commands
{
    public class DeleteLivroHandler : IRequestHandler<DeleteLivroCommand, LivroModel>
    {
        private readonly ILivro _livroService;

        public DeleteLivroHandler(ILivro livroService)
        {
            _livroService = livroService;
        }

        public async Task<LivroModel> Handle(DeleteLivroCommand request, CancellationToken cancellationToken)
        {
            return await _livroService.ExcluirLivro(request.IdLivro);
        }
    }
}
