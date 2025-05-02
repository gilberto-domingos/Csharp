using MediatR;
using ApiRestFull.Models;

namespace ApiRestFull.Queries.Livro
{
    public record ListarLivrosQuery() : IRequest<List<LivroModel>>;
}
