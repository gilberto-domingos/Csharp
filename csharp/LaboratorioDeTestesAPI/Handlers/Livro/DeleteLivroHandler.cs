using MediatR;
using LaboratorioDeTestesAPI.Interfaces;
using LaboratorioDeTestesAPI.Entities;

namespace LaboratorioDeTestesAPI.Handlers.Livro.Commands
{
    public class DeleteLivroHandler : IRequestHandler<DeleteLivroCommand, Entities.Livro>
    {
        private readonly ILivro _livroService;

        public DeleteLivroHandler(ILivro livroService)
        {
            _livroService = livroService;
        }

        public async Task<Entities.Livro> Handle(DeleteLivroCommand request, CancellationToken cancellationToken)
        {
            return await _livroService.ExcluirLivro(request.IdLivro);
        }
    }
}
