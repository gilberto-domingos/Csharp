using MediatR;

namespace LaboratorioDeTestes.Handlers.Livro.Commands
{
    public record DeleteLivroCommand(Guid IdLivro) : IRequest<Entities.Livro>;
}
