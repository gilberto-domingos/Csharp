using ApiRestFull.Entities;
using MediatR;

namespace ApiRestFull.Queries.Autor
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
