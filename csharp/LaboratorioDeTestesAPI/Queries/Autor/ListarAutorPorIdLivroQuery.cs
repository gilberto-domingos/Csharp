using LaboratorioDeTestesAPI.Entities;
using MediatR;

namespace LaboratorioDeTestesAPI.Queries.Autor
{
    public class ListarAutorPorIdLivroQuery : IRequest<Entities.Autor>
    {
        public Guid IdLivro { get; }

        public ListarAutorPorIdLivroQuery(Guid idLivro)
        {
            IdLivro = idLivro;
        }
    }
}
