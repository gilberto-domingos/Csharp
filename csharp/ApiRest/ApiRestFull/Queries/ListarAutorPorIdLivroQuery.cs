using ApiRestFull.DTOs;
using ApiRestFull.Models;
using MediatR;

namespace ApiRestFull.Queries.Autor
{
    public class ListarAutorPorIdLivroQuery : IRequest<RespostaApiDto<AutorModel>>
    {
        public Guid IdLivro { get; set; }

        public ListarAutorPorIdLivroQuery(Guid idLivro)
        {
            IdLivro = idLivro;
        }
    }
}
