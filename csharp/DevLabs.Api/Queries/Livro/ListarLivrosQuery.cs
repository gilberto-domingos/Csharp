using MediatR;

namespace LaboratorioDeTestes.Queries.Livro
{
    public record ListarLivrosQuery() : IRequest<List<Entities.Livro>>;
}
