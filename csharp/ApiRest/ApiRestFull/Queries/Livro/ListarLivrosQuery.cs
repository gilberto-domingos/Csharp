using MediatR;
using ApiRestFull.Entities;

namespace ApiRestFull.Queries.Livro
{
    public record ListarLivrosQuery() : IRequest<List<Entities.Livro>>;
}
