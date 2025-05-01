using ApiRestFull.DTOs;
using ApiRestFull.Models;
using MediatR;

namespace ApiRestFull.Commands.Autor
{
    public class EditarAutorCommand : IRequest<RespostaApiDto<List<AutorModel>>>
    {
        public AutorEditarDto AutorEditarDto { get; }

        public EditarAutorCommand(AutorEditarDto autorEditarDto)
        {
            AutorEditarDto = autorEditarDto;
        }
    }
}
