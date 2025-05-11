using LaboratorioDeTestes.Interfaces;
using MediatR;
using LaboratorioDeTestes.Entities;

namespace LaboratorioDeTestes.Handlers.Livro.Commands
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
