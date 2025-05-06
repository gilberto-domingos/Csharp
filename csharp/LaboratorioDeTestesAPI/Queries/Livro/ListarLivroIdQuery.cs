using MediatR;
using LaboratorioDeTestesAPI.Entities;

namespace LaboratorioDeTestesAPI.Handlers.Livro.Queries
{
    public record ListarLivroIdQuery(Guid IdLivro) : IRequest<Entities.Livro>;
}
