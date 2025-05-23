using DevLabs.Api.Handlers.Livro.Commands;
using DevLabs.Api.Interfaces;
using MediatR;

namespace DevLabs.Api.Handlers.Livro
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
