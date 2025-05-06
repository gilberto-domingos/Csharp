using LaboratorioDeTestesAPI.Dtos;
using LaboratorioDeTestesAPI.Entities;
using MediatR;

namespace LaboratorioDeTestesAPI.Commands.Autor
{
    public class EditarAutorCommand : IRequest<Entities.Autor>
    {
        public AutorEditarDto AutorEditarDto { get; set; }

        public EditarAutorCommand(AutorEditarDto autorEditarDto)
        {
            AutorEditarDto = autorEditarDto;
        }
    }
}
