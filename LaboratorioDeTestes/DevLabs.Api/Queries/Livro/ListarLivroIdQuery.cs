using MediatR;
using DevLabs.Api.Entities;

namespace DevLabs.Api.Handlers.Livro.Queries
{
    public record ListarLivroIdQuery(Guid IdLivro) : IRequest<Entities.Livro>;
}
