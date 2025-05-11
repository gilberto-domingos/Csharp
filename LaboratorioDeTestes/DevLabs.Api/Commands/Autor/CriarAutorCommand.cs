using DevLabs.Api.Dtos;
using MediatR;

namespace DevLabs.Api.Commands.Autor
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
