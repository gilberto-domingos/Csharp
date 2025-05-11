using LaboratorioDeTestes.Dtos;
using MediatR;

namespace LaboratorioDeTestes.Commands.Autor
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
