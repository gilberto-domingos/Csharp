using MediatR;
using LaboratorioDeTestesAPI.Entities;

namespace LaboratorioDeTestesAPI.Queries.Livro
{
    public record ListarLivrosQuery() : IRequest<List<Entities.Livro>>;
}
