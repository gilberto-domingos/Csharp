using MediatR;

namespace LaboratorioDeTestesAPI.Handlers.Livro.Commands
{
    public record DeleteLivroCommand(Guid IdLivro) : IRequest<Entities.Livro>;
}
