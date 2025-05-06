using LaboratorioDeTestesAPI.Dtos;
using MediatR;

namespace LaboratorioDeTestesAPI.Commands.Autor
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
