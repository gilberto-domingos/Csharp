using LaboratorioDeTestesAPI.Entities;
using MediatR;

namespace LaboratorioDeTestesAPI.Queries.Autor
{
    public class ListarAutoresQuery : IRequest<List<Entities.Autor>>
    {
    }
}
