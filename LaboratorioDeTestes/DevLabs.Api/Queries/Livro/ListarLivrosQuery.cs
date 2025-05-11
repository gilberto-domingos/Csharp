using MediatR;

namespace DevLabs.Api.Queries.Livro
{
    public record ListarLivrosQuery() : IRequest<List<Entities.Livro>>;
}
