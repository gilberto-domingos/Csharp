using DevLabs.Api.Dtos;
using MediatR;

namespace DevLabs.Api.Commands.Livro
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
