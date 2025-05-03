using ApiRestFull.DTOs;
using ApiRestFull.Entities;
using MediatR;

namespace ApiRestFull.Commands.Autor
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
