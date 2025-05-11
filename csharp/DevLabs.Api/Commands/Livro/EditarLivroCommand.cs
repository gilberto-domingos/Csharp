using LaboratorioDeTestes.Dtos;
using MediatR;
using LaboratorioDeTestes.Entities;

namespace LaboratorioDeTestes.Handlers.Commands
{
    public class EditarLivroCommand : IRequest<Entities.Livro>
    {
        public LivroEditarDto LivroEditarDto { get; set; }

        public EditarLivroCommand(LivroEditarDto livroEditarDto)
        {
            LivroEditarDto = livroEditarDto;
        }
    }
}
