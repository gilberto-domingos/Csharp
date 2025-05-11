using MediatR;

namespace DevLabs.Api.Handlers.Livro.Commands
{
    public record DeleteLivroCommand(Guid IdLivro) : IRequest<Entities.Livro>;
}
