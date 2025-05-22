using MediatR;

namespace ApiRestFull.Queries.Livro
{
    public record ListarLivrosPorIdAutorQuery(Guid IdAutor) : IRequest<List<Entities.Livro>>;
}
