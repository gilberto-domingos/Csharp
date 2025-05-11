using LaboratorioDeTestes.Entities;
using MediatR;

namespace LaboratorioDeTestes.Queries.Autor
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
