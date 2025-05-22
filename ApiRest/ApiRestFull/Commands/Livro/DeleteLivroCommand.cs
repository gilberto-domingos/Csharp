using MediatR;

namespace ApiRestFull.Commands
{
    public record DeleteLivroCommand(Guid IdLivro) : IRequest<Entities.Livro>;
}
