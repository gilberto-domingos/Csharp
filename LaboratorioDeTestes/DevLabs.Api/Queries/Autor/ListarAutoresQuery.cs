using DevLabs.Api.Entities;
using MediatR;

namespace DevLabs.Api.Queries.Autor
{
    public class ListarAutoresQuery : IRequest<List<Entities.Autor>>
    {
    }
}
