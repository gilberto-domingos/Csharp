using MediatR;
using LaboratorioDeTestesAPI.Entities;

namespace LaboratorioDeTestesAPI.Handlers.Livro.Queries
{
    public record ListarLivrosPorIdAutorQuery(Guid IdAutor) : IRequest<List<Entities.Livro>>;
}
