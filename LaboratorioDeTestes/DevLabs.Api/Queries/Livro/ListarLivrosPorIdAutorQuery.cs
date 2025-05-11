using MediatR;
using DevLabs.Api.Entities;

namespace DevLabs.Api.Handlers.Livro.Queries
{
    public record ListarLivrosPorIdAutorQuery(Guid IdAutor) : IRequest<List<Entities.Livro>>;
}
