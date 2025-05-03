using ApiRestFull.Entities;
using MediatR;

namespace ApiRestFull.Queries.Autor
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
