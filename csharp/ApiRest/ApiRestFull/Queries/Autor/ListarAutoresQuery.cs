using ApiRestFull.Models;
using MediatR;

namespace ApiRestFull.Queries.Autor
{
    public class ListarAutoresQuery : IRequest<List<AutorModel>>
    {
    }
}
