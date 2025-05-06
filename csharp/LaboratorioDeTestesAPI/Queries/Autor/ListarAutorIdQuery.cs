using LaboratorioDeTestesAPI.Entities;
using MediatR;

namespace LaboratorioDeTestesAPI.Queries.Autor
{
    public class ListarAutorIdQuery : IRequest<Entities.Autor>
    {
        public Guid IdAutor { get; }

        public ListarAutorIdQuery(Guid idAutor)
        {
            IdAutor = idAutor;
        }
    }
}
