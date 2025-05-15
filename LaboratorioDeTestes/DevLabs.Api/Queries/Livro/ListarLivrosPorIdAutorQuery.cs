using MediatR;
using DevLabs.Api.Entities;

namespace DevLabs.Api.Queries.Livro
{
    public record ListarLivrosPorIdAutorQuery(Guid IdAutor) : IRequest<List<Entities.Livro>>;
}
