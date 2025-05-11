using DevLabs.Api.Dtos;
using MediatR;
using DevLabs.Api.Entities;

namespace DevLabs.Api.Handlers.Commands
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
