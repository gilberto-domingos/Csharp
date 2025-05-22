using ApiRestFull.Commands;
using MediatR;
using ApiRestFull.Interfaces;

namespace ApiRestFull.Handlers.Commands
{
    public class EditarLivroCommandHandler : IRequestHandler<EditarLivroCommand, Entities.Livro>
    {
        private readonly ILivro _livroService;

        public EditarLivroCommandHandler(ILivro livroService)
        {
            _livroService = livroService;
        }

        public async Task<Entities.Livro> Handle(EditarLivroCommand request, CancellationToken cancellationToken)
        {
            return await _livroService.EditarLivro(request.LivroEditarDto);
        }
    }
}
