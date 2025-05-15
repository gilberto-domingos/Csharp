using MediatR;

namespace DevLabs.Api.Queries.Autor
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
