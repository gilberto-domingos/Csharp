using MediatR;
using ApiRestFull.Entities;

namespace ApiRestFull.Handlers.Livro.Queries
{
    public record ListarLivroIdQuery(Guid IdLivro) : IRequest<Entities.Livro>;
}
