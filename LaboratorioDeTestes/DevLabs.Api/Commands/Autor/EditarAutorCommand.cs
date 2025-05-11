using DevLabs.Api.Dtos;
using DevLabs.Api.Entities;
using MediatR;

namespace DevLabs.Api.Commands.Autor
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
