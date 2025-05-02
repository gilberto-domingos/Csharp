using MediatR;
using ApiRestFull.Models;

namespace ApiRestFull.Handlers.Livro.Queries
{
    public record ListarLivroIdQuery(Guid IdLivro) : IRequest<LivroModel>;
}
