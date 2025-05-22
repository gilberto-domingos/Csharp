using MediatR;

namespace ApiRestFull.Queries.Autor
{
    public class ListarAutoresQuery : IRequest<List<Entities.Autor>>
    {
    }
}
