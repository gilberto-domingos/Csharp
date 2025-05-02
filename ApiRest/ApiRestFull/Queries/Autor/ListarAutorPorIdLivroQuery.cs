using ApiRestFull.Models;
using MediatR;

namespace ApiRestFull.Queries.Autor
{
    public class ListarAutorPorIdLivroQuery : IRequest<AutorModel>
    {
        public Guid IdLivro { get; }

        public ListarAutorPorIdLivroQuery(Guid idLivro)
        {
            IdLivro = idLivro;
        }
    }
}
