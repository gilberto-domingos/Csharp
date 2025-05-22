using ApiRestFull.Commands;
using MediatR;
using ApiRestFull.Interfaces;

namespace ApiRestFull.Handlers.Livro
{
    public class UpdateLivroHandler : IRequestHandler<UpdateLivroCommand, Entities.Livro>
    {
        private readonly ILivro _livroService;

        public UpdateLivroHandler(ILivro livroService)
        {
            _livroService = livroService;
        }

        public async Task<Entities.Livro> Handle(UpdateLivroCommand request, CancellationToken cancellationToken)
        {
            return await _livroService.EditarLivro(request.LivroEditarDto);
        }
    }
}
