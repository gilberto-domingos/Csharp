using LaboratorioDeTestes.Entities;
using MediatR;

namespace LaboratorioDeTestes.Queries.Autor
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
