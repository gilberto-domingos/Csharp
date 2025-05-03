using ApiRestFull.DTOs;
using ApiRestFull.Entities;
using MediatR;

namespace ApiRestFull.Commands.Autor
{
    public class CriarAutorCommand : IRequest<Entities.Autor>
    {
        public AutorCriarDto AutorCriarDto { get; }

        public CriarAutorCommand(AutorCriarDto autorCriarDto)
        {
            AutorCriarDto = autorCriarDto;
        }
    }
}
