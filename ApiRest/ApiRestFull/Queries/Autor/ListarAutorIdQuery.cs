using ApiRestFull.Models;
using MediatR;

namespace ApiRestFull.Queries.Autor
{
    public class ListarAutorIdQuery : IRequest<AutorModel>
    {
        public Guid IdAutor { get; }

        public ListarAutorIdQuery(Guid idAutor)
        {
            IdAutor = idAutor;
        }
    }
}
