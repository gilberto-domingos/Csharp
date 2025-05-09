using MediatR;

namespace LaboratorioDeTestesAPI.Queries.Livro
{
    public record ListarLivrosQuery() : IRequest<List<Entities.Livro>>;
}
