using MediatR;
using LaboratorioDeTestesAPI.Dtos;
using LaboratorioDeTestesAPI.Entities;

namespace LaboratorioDeTestesAPI.Handlers.Commands
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
