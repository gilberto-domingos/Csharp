using MediatR;
using ApiRestFull.Models;

namespace ApiRestFull.Handlers.Livro.Queries
{
    public record ListarLivrosPorIdAutorQuery(Guid IdAutor) : IRequest<List<LivroModel>>;
}
