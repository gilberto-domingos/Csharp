using MediatR;
using ApiRestFull.Entities;

namespace ApiRestFull.Queries.Livro
{
    public record ListarLivroIdQuery(Guid IdLivro) : IRequest<Entities.Livro>;
}
