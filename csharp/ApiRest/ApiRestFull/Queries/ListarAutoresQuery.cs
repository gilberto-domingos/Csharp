using ApiRestFull.Models;
using ApiRestFull.DTOs;
using MediatR;

namespace ApiRestFull.Queries.Autor
{
    public class ListarAutoresQuery : IRequest<RespostaApiDto<List<AutorModel>>>
    {
    }
}
