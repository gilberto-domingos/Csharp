using MediatR;
using ApiRestFull.Entities;

namespace ApiRestFull.Handlers.Livro.Queries
{
    public record ListarLivrosPorIdAutorQuery(Guid IdAutor) : IRequest<List<Entities.Livro>>;
}
