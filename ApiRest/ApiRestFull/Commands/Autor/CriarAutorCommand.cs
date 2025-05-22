using ApiRestFull.Dtos;
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
