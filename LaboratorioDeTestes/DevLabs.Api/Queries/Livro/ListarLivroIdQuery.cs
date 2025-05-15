using MediatR;

namespace DevLabs.Api.Queries.Livro
{
    public record ListarLivroIdQuery(Guid IdLivro) : IRequest<Entities.Livro>;
}
