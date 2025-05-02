using ApiRestFull.DTOs;
using ApiRestFull.Models;
using MediatR;

namespace ApiRestFull.Commands.Autor
{
    public class ExcluirAutorCommand : IRequest<AutorModel>
    {
        public Guid IdAutor { get; }

        public ExcluirAutorCommand(Guid idAutor)
        {
            IdAutor = idAutor;
        }
    }
}
