using MediatR;
using LaboratorioDeTestes.Entities;

namespace LaboratorioDeTestes.Handlers.Livro.Queries
{
    public record ListarLivrosPorIdAutorQuery(Guid IdAutor) : IRequest<List<Entities.Livro>>;
}
