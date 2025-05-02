using ApiRestFull.DTOs;
using ApiRestFull.Models;
using MediatR;

namespace ApiRestFull.Commands.Autor
{
    public class CriarAutorCommand : IRequest<AutorModel>
    {
        public AutorCriarDto AutorCriarDto { get; }

        public CriarAutorCommand(AutorCriarDto autorCriarDto)
        {
            AutorCriarDto = autorCriarDto;
        }
    }
}
