using ApiRestFull.DTOs;
using ApiRestFull.Models;
using MediatR;

namespace ApiRestFull.Commands.Autor
{
    public class EditarAutorCommand : IRequest<AutorModel>
    {
        public AutorEditarDto AutorEditarDto { get; set; }

        public EditarAutorCommand(AutorEditarDto autorEditarDto)
        {
            AutorEditarDto = autorEditarDto;
        }
    }
}
