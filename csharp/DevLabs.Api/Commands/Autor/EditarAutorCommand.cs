using LaboratorioDeTestes.Dtos;
using LaboratorioDeTestes.Entities;
using MediatR;

namespace LaboratorioDeTestes.Commands.Autor
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
