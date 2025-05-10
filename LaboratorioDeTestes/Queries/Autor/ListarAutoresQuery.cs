using LaboratorioDeTestes.Entities;
using MediatR;

namespace LaboratorioDeTestes.Queries.Autor
{
    public class ListarAutoresQuery : IRequest<List<Entities.Autor>>
    {
    }
}
