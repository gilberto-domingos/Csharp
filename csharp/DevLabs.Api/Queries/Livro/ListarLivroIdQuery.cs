using MediatR;
using LaboratorioDeTestes.Entities;

namespace LaboratorioDeTestes.Handlers.Livro.Queries
{
    public record ListarLivroIdQuery(Guid IdLivro) : IRequest<Entities.Livro>;
}
